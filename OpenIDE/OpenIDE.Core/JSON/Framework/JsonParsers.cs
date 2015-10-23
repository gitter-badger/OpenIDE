﻿namespace TinyJson.Framework
{
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Globalization;

   public abstract class JsonParsers<TInput> : CharParsers<TInput>
   {
      protected JsonParsers()
      {  
         Whitespace = Rep(Char(' ').OR(Char('\t').OR(Char('\n')).OR(Char('\r'))));
         Id = from w in Whitespace
              from c in Char(char.IsLetter)
              from cs in Rep(Char(char.IsLetter))
              select cs.Aggregate(c.ToString(), (acc, ch) => acc + ch);
         WsChr = chr => Whitespace.AND(Char(chr));
         PString = from begin in WsChr('"')
                   from cs in Rep(EscapedChar())
                   from end in Char('"').REQUIRED("Expected end of string '\"', found end of file")
                   select (Object)(cs.Aggregate(string.Empty, (acc, ch) => acc + ch));
         PNumber = from whitespace in Whitespace
                   from n in Char(char.IsDigit)
                   from ns in Rep(Char(char.IsDigit))
                   select (Object)double.Parse(ns.Aggregate(n.ToString(), (acc, ch) => acc + ch));
         PArray = from begin in WsChr('[')
                  from values in
                     Rep(from value in Value
                         from comma in Rep(Char(','))
                         select value)
                  from end in WsChr(']').REQUIRED("Expected end of array ']', found end of file")
                  select (Object)new ArrayValue(values);
         PObject = from begin in WsChr('{')
                   from props in
                      Rep(from prop in Prop
                          from comma in Rep(Char(','))
                          select prop)
                   from end in WsChr('}').REQUIRED("Expected end of object '}', found end of file")
                   select (Object)new ObjectValue(props.ToDictionary(kvp => kvp.Key, kvp => kvp.Value));
         Prop = from identifier in PString
                from colon in WsChr(':')
                from value in Value
                from comma in Rep(Char(','))
                select new KeyValuePair<string, Object>((string)identifier, value);
         PBool = from id in Id
                 where (id == "true" || id == "false")
                 select (Object)bool.Parse(id);
         PNull = from id in Id
                 where (id == "null")
                 select (Object)null;
         Value = PNumber
            .OR(PArray)
            .OR(PString)
            .OR(PObject)
            .OR(PBool)
            .OR(PNull);
//            .REQUIRED("Input was not a valid JSON value");
         All = Value;
      }

      public Parser<TInput, char[]> Whitespace;
      public Func<char, Parser<TInput, char>> WsChr;
      public Parser<TInput, char> ThrowException;
      public Parser<TInput, string> Id;
      public Parser<TInput, Object> Value;
      public Parser<TInput, Object> PString;
      public Parser<TInput, Object> PNumber;
      public Parser<TInput, Object> PObject;
      public Parser<TInput, Object> PArray;
      public Parser<TInput, Object> PBool;
      public Parser<TInput, Object> PNull;
      
      public Parser<TInput, KeyValuePair<string, Object>> Prop;
      public Parser<TInput, Object> All;

      public Parser<TInput, char> EscapedChar()
      {
         return input =>
         {
            var result1 = AnyChar(input);

            if (result1 == null || result1.Value == '"')
               return null;

            if (result1.Value != '\\')
               return result1;

            var result2 = AnyChar(result1.Rest);

            char value;
            switch (result2.Value)
            {
               case '\\':
                  value = '\\';
                  break;
               case '\"':
                  value = '\"';
                  break;
               case 'r':
                  value = '\r';
                  break;
               case 'n':
                  value = '\n';
                  break;
               case 't':
                  value = '\t';
                  break;
               case '/':
                  value = '/';
                  break;
               case 'u':
                  var char1 = AnyChar(result2.Rest);
                  var char2 = AnyChar(char1.Rest);
                  var char3 = AnyChar(char2.Rest);
                  result2 = AnyChar(char3.Rest);

                  var charCode = Int32.Parse(char1.Value.ToString() + char2.Value + char3.Value + result2.Value, NumberStyles.HexNumber);
                  value = Convert.ToChar(charCode);
                  break;
               default:
                  throw new Json.ParseException("Unknown escape sequence '\\" + result2.Value + "'");
            }

            return new Result<TInput, char>(value, result2.Rest);
         };
      }
   }
}