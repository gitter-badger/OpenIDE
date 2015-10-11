namespace System.IO.FilterBuilder
{
    /// <summary>
    /// Helper methods.
    /// </summary>
    static internal class Helpers
    {

        #region " Public methods "

        /// <summary>
        /// Returns the specified filter as a filter string.
        /// </summary>
        /// <param name="filter">
        /// The filter to return.
        /// </param>
        /// <returns>
        /// The string representation of the filter.
        /// </returns>
        public static string ReturnFilterAsString(GrammarEdit.Core.FilterBuilder.Filters filter)
        {

            //Return the correct filter string for the filter items
            switch (filter)
            {

                case GrammarEdit.Core.FilterBuilder.Filters.WordDocuments:

                    return "Microsoft Word Documents (*.doc)|*.doc";
                case GrammarEdit.Core.FilterBuilder.Filters.WordOpenXMLDocuments:

                    return "Microsoft Word Open XML Documents (*.docx)|*.docx";
                case GrammarEdit.Core.FilterBuilder.Filters.LogFiles:

                    return "Log Files (*.log)|*.log";
                case GrammarEdit.Core.FilterBuilder.Filters.MailMessages:

                    return "Mail Messages (*.msg)|*.msg";
                case GrammarEdit.Core.FilterBuilder.Filters.PagesDocuments:

                    return "Pages Documents (*.pages)|*.pages";
                case GrammarEdit.Core.FilterBuilder.Filters.RichTextFiles:

                    return "Rich Text Files (*.rtf)|*.rtf";
                case GrammarEdit.Core.FilterBuilder.Filters.TextFiles:

                    return "Plain Text Files (*.txt)|*.txt";
                case GrammarEdit.Core.FilterBuilder.Filters.WordPerfectDocuments:

                    return "WordPerfect Documents (*.wpd)|*.wpd";
                case GrammarEdit.Core.FilterBuilder.Filters.WorksWordProcessorDocuments:

                    return "Microsoft Works Word Processor Documents (*.wps)|*.wps";
                case GrammarEdit.Core.FilterBuilder.Filters.Lotus123Spreadsheets:

                    return "Lotus 1-2-3 Spreadsheets (*.123)|*.123";
                case GrammarEdit.Core.FilterBuilder.Filters.Access2007DatabaseFiles:

                    return "Access 2007 Database Files (*.accdb)|*.accdb";
                case GrammarEdit.Core.FilterBuilder.Filters.CSV_Files:

                    return "Comma Separated Values Files (*.csv)|*.csv";
                case GrammarEdit.Core.FilterBuilder.Filters.DataFiles:

                    return "Data Files (*.dat)|*.dat";
                case GrammarEdit.Core.FilterBuilder.Filters.DatabaseFiles:

                    return "Database Files (*.db)|*.db";
                case GrammarEdit.Core.FilterBuilder.Filters.DLL_Files:

                    return "Dynamic Link Library Files (*.dll)|*.dll";
                case GrammarEdit.Core.FilterBuilder.Filters.AccessDatabaseFiles:

                    return "Microsoft Access Database Files (*.mdb)|*.mdb";
                case GrammarEdit.Core.FilterBuilder.Filters.PowerPointSlideShows:

                    return "PowerPoint Slide Shows (*.pps)|*.pps";
                case GrammarEdit.Core.FilterBuilder.Filters.PowerPointPresentations:

                    return "PowerPoint Presentations (*.ppt)|*.ppt";
                case GrammarEdit.Core.FilterBuilder.Filters.PowerPointOpenXMLDocuments:

                    return "Microsoft PowerPoint Open XML Documents (*.pptx)|*.pptx";
                case GrammarEdit.Core.FilterBuilder.Filters.OpenOfficeBaseDatabaseFiles:

                    return "OpenOffice.org Base Database Files (*.sdb)|*.sdb";
                case GrammarEdit.Core.FilterBuilder.Filters.SQLDataFiles:

                    return "SQL Data Files (*.sql)|*.sql";
                case GrammarEdit.Core.FilterBuilder.Filters.vCardFiles:

                    return "vCard Files (*.vcf)|*.vcf";
                case GrammarEdit.Core.FilterBuilder.Filters.UCConversionFiles:

                    return "Universal Converter Conversion Files (*.ucv)|*.ucv";
                case GrammarEdit.Core.FilterBuilder.Filters.WorksSpreadsheets:

                    return "Microsoft Works Spreadsheets (*.wks)|*.wks";
                case GrammarEdit.Core.FilterBuilder.Filters.ExcelSpreadsheets:

                    return "Microsoft Excel Spreadsheets (*.xls)|*.xls";
                case GrammarEdit.Core.FilterBuilder.Filters.ExcelOpenXMLDocuments:

                    return "Microsoft Excel Open XML Documents (*.xlsx)|*.xlsx";
                case GrammarEdit.Core.FilterBuilder.Filters.XML_Files:

                    return "XML Files (*.xml)|*.xml";
                case GrammarEdit.Core.FilterBuilder.Filters.BMP_ImageFiles:

                    return "Bitmap Image Files (*.bmp)|*.bmp";
                case GrammarEdit.Core.FilterBuilder.Filters.GIF_ImageFiles:

                    return "Graphical Interchange Format Files (*.gif)|*.gif";
                case GrammarEdit.Core.FilterBuilder.Filters.JPEG_ImageFiles:

                    return "JPEG Image Files (*.jpg,*.jpeg)|*.jpg;*.jpeg";
                case GrammarEdit.Core.FilterBuilder.Filters.PNG_ImageFiles:

                    return "Portable Network Graphic Files (*.png)|*.png";
                case GrammarEdit.Core.FilterBuilder.Filters.AllImageFiles:

                    return "All Supported Image Files|*.bmp;*.gif;*.jpg" + ";*.jpeg;*.png;*.tif;*.tiff";
                case GrammarEdit.Core.FilterBuilder.Filters.PhotoshopDocuments:

                    return "Photoshop Documents (*.psd)|*.psd";
                case GrammarEdit.Core.FilterBuilder.Filters.PaintShopProImageFiles:

                    return "Paint Shop Pro Image Files (*.psp)|*.psp";
                case GrammarEdit.Core.FilterBuilder.Filters.ThumbnailImageFiles:

                    return "Thumbnail Image Files (*.thm)|*.thm";
                case GrammarEdit.Core.FilterBuilder.Filters.TIFF_ImageFiles:

                    return "Tagged Image Files (*.tif,*.tiff)|*.tif;*.tiff";
                case GrammarEdit.Core.FilterBuilder.Filters.AdobeIllustratorFiles:

                    return "Adobe Illustrator Files (*.ai)|*.ai";
                case GrammarEdit.Core.FilterBuilder.Filters.DrawingFiles:

                    return "Drawing Files (*.drw)|*.drw";
                case GrammarEdit.Core.FilterBuilder.Filters.DrawingExchangeFormatFiles:

                    return "Drawing Exchange Format Files (*.dxf)|*.dxf";
                case GrammarEdit.Core.FilterBuilder.Filters.EncapsulatedPostScriptFiles:

                    return "Encapsulated PostScript Files (*.eps)|*.eps";
                case GrammarEdit.Core.FilterBuilder.Filters.PostScriptFiles:

                    return "PostScript Files (*.ps)|*.ps";
                case GrammarEdit.Core.FilterBuilder.Filters.SVG_Files:

                    return "Scalable Vector Graphics Files (*.svg)|*.svg";
                case GrammarEdit.Core.FilterBuilder.Filters.Rhino3DModels:

                    return "Rhino 3D Models (*.3dm)|*.3dm";
                case GrammarEdit.Core.FilterBuilder.Filters.AutoCADDrawingDatabaseFiles:

                    return "AutoCAD Drawing Database Files (*.dwg)|*.dwg";
                case GrammarEdit.Core.FilterBuilder.Filters.ArchiCADProjectFiles:

                    return "ArchiCAD Project Files (*.pln)|*.pln";
                case GrammarEdit.Core.FilterBuilder.Filters.AdobeInDesignFiles:

                    return "Adobe InDesign Files (*.indd)|*.indd";
                case GrammarEdit.Core.FilterBuilder.Filters.PDF_Files:

                    return "Portable Document Format Files (*.pdf)|*.pdf";
                case GrammarEdit.Core.FilterBuilder.Filters.AAC_Files:

                    return "Advanced Audio Coding Files (*.aac)|*.aac";
                case GrammarEdit.Core.FilterBuilder.Filters.AIF_Files:

                    return "Audio Interchange File Format Files (*.aif)|*.aif";
                case GrammarEdit.Core.FilterBuilder.Filters.IIF_Files:

                    return "Interchange File Format Files (*.iif)|*.iif";
                case GrammarEdit.Core.FilterBuilder.Filters.MediaPlaylistFiles:

                    return "Media Playlist Files (*.m3u)|*.m3u";
                case GrammarEdit.Core.FilterBuilder.Filters.MIDI_Files:

                    return "MIDI Files (*.mid,*.midi)|*.mid;*.midi";
                case GrammarEdit.Core.FilterBuilder.Filters.MP3_AudioFiles:

                    return "MP3 Audio Files (*.mp3)|*.mp3";
                case GrammarEdit.Core.FilterBuilder.Filters.MPEG2_AudioFiles:

                    return "MPEG-2 Audio Files (*.mpa)|*.mpa";
                case GrammarEdit.Core.FilterBuilder.Filters.RealAudioFiles:

                    return "Real Audio Files (*.ra)|*.ra";
                case GrammarEdit.Core.FilterBuilder.Filters.WAVE_AudioFiles:

                    return "WAVE Audio Files (*.wav)|*.wav";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsMediaAudioFiles:

                    return "Windows Media Audio Files (*.wma)|*.wma";
                case GrammarEdit.Core.FilterBuilder.Filters._3GPP2MultimediaFiles:

                    return "3GPP2 Multimedia Files (*.3g2)|*.3g2";
                case GrammarEdit.Core.FilterBuilder.Filters._3GPPMultimediaFiles:

                    return "3GPP Multimedia Files (*.3gp)|*.3gp";
                case GrammarEdit.Core.FilterBuilder.Filters.AVI_Files:

                    return "Audio Video Interleave Files (*.avi)|*.avi";
                case GrammarEdit.Core.FilterBuilder.Filters.FlashVideoFiles:

                    return "Flash Video Files (*.flv)|*.flv";
                case GrammarEdit.Core.FilterBuilder.Filters.MatroskaVideoFiles:

                    return "Matroska Video Files (*.mkv)|*.mkv";
                case GrammarEdit.Core.FilterBuilder.Filters.AppleQuickTimeMoviesMov:

                    return "Apple QuickTime Movie Files (*.mov)|*.mov";
                case GrammarEdit.Core.FilterBuilder.Filters.MPEG4_VideoFiles:

                    return "MPEG-4 Video Files (*.mp4)|*.mp4";
                case GrammarEdit.Core.FilterBuilder.Filters.MPEG_VideoFiles:

                    return "MPEG Video Files (*.mpg)|*.mpg";
                case GrammarEdit.Core.FilterBuilder.Filters.AppleQuickTimeMoviesQT:

                    return "Apple QuickTime Movie Files (*.qt)|*.qt";
                case GrammarEdit.Core.FilterBuilder.Filters.RealMediaFiles:

                    return "Real Media Files (*.rm)|*.rm";
                case GrammarEdit.Core.FilterBuilder.Filters.FlashMovies:

                    return "Flash Movies (*.swf)|*.swf";
                case GrammarEdit.Core.FilterBuilder.Filters.DVDVideoObjectFiles:

                    return "DVD Video Object Files (*.vob)|*.vob";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsMediaVideoFiles:

                    return "Windows Media Video Files (*.wmv)|*.wmv";
                case GrammarEdit.Core.FilterBuilder.Filters.ActiveServerPages:

                    return "Active Server Pages (*.asp)|*.asp";
                case GrammarEdit.Core.FilterBuilder.Filters.CascadingStyleSheets:

                    return "Cascading Style Sheets (*.css)|*.css";
                case GrammarEdit.Core.FilterBuilder.Filters.HTML_Files:

                    return "HTML Files (*.htm,*.html)|*.htm;*.html";
                case GrammarEdit.Core.FilterBuilder.Filters.JavaScriptFiles:

                    return "JavaScript Files (*.js)|*.js";
                case GrammarEdit.Core.FilterBuilder.Filters.JavaServerPages:

                    return "Java Server Pages (*.jsp)|*.jsp";
                case GrammarEdit.Core.FilterBuilder.Filters.PHP_Files:

                    return "Hypertext Preprocessor Files (*.php)|*.php";
                case GrammarEdit.Core.FilterBuilder.Filters.RichSiteSummaryFiles:

                    return "Rich Site Summary Files (*.rss)|*.rss";
                case GrammarEdit.Core.FilterBuilder.Filters.XHTML_Files:

                    return "XHTML Files (*.xhtml)|*.xhtml";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsFontFiles:

                    return "Windows Font Files (*.fnt)|*.fnt";
                case GrammarEdit.Core.FilterBuilder.Filters.GenericFontFiles:

                    return "Generic Font Files (*.fon)|*.fon";
                case GrammarEdit.Core.FilterBuilder.Filters.OpenTypeFonts:

                    return "OpenType Fonts (*.otf)|*.otf";
                case GrammarEdit.Core.FilterBuilder.Filters.TrueTypeFonts:

                    return "TrueType Fonts (*.ttf)|*.ttf";
                case GrammarEdit.Core.FilterBuilder.Filters.ExcelAddInFiles:

                    return "Excel Add-In Files (*.xll)|*.xll";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsCabinetFiles:

                    return "Windows Cabinet Files (*.cab)|*.cab";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsControlPanel:

                    return "Windows Control Panel (*.cpl)|*.cpl";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsCursors:

                    return "Windows Cursors (*.cur)|*.cur";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsMemoryDumps:

                    return "Windows Memory Dumps (*.dmp)|*.dmp";
                case GrammarEdit.Core.FilterBuilder.Filters.DeviceDrivers:

                    return "Device Drivers (*.drv)|*.drv";
                case GrammarEdit.Core.FilterBuilder.Filters.SecurityKeys:

                    return "Security Keys (*.key)|*.key";
                case GrammarEdit.Core.FilterBuilder.Filters.FileShortcuts:

                    return "File Shortcuts (*.lnk)|*.lnk";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsSystemFiles:

                    return "Windows System Files (*.sys)|*.sys";
                case GrammarEdit.Core.FilterBuilder.Filters.ConfigurationFiles:

                    return "Configuration Files (*.cfg)|*.cfg";
                case GrammarEdit.Core.FilterBuilder.Filters.INI_Files:

                    return "Windows Initialization Files (*.ini)|*.ini";
                case GrammarEdit.Core.FilterBuilder.Filters.OutlookProfileFiles:

                    return "Outlook Profile Files (*.prf)|*.prf";
                case GrammarEdit.Core.FilterBuilder.Filters.MacOSXApplications:

                    return "Mac OS X Applications (*.app)|*.app";
                case GrammarEdit.Core.FilterBuilder.Filters.DOSBatchFiles:

                    return "DOS Batch Files (*.bat)|*.bat";
                case GrammarEdit.Core.FilterBuilder.Filters.CGI_Files:

                    return "Common Gateway Interface Scripts (*.cgi)|*.cgi";
                case GrammarEdit.Core.FilterBuilder.Filters.DOSCommandFiles:

                    return "DOS Command Files (*.com)|*.com";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsExecutableFiles:

                    return "Windows Executable File (*.exe)|*.exe";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsScripts:

                    return "Windows Scripts (*.ws)|*.ws";
                case GrammarEdit.Core.FilterBuilder.Filters._7ZipCompressedFiles:

                    return "7-Zip Compressed Files (*.7z)|*.7z";
                case GrammarEdit.Core.FilterBuilder.Filters.DebianSoftwarePackages:

                    return "Debian Software Packages (*.deb)|*.deb";
                case GrammarEdit.Core.FilterBuilder.Filters.GnuZippedFile:

                    return "Gnu Zipped Files (*.gz)|*.gz";
                case GrammarEdit.Core.FilterBuilder.Filters.MacOSXInstallerPackages:

                    return "Mac OS X Installer Packages (*.pkg)|*.pkg";
                case GrammarEdit.Core.FilterBuilder.Filters.WinRARCompressedArchives:

                    return "WinRAR Compressed Archives (*.rar)|*.rar";
                case GrammarEdit.Core.FilterBuilder.Filters.SelfExtractingArchives:

                    return "Self-Extractingd Archives (*.sea)|*.sea";
                case GrammarEdit.Core.FilterBuilder.Filters.StuffitArchives:

                    return "Stuffit Archives (*.sit)|*.sit";
                case GrammarEdit.Core.FilterBuilder.Filters.StuffitXArchives:

                    return "Stuffit X Archives (*.sitx)|*.sitx";
                case GrammarEdit.Core.FilterBuilder.Filters.ZippedFiles:

                    return "Zipped Files (*.zip)|*.zip";
                case GrammarEdit.Core.FilterBuilder.Filters.ExtendedZipFiles:

                    return "Extended Zip Files (*.zipx)|*.zipx";
                case GrammarEdit.Core.FilterBuilder.Filters.BinHex4EncodedFiles:

                    return "BinHex 4.0 Encoded Files (*.hqx)|*.hqx";
                case GrammarEdit.Core.FilterBuilder.Filters.MultiPurposeInternetMailMessages:

                    return "Multi-Purpose Internet Mail Messages (*.mim)|*.mim";
                case GrammarEdit.Core.FilterBuilder.Filters.UuencodedFiles:

                    return "Uuencoded Files (*.uue)|*.uue";
                case GrammarEdit.Core.FilterBuilder.Filters.C_CPlusPlus_SourceCodeFiles:

                    return "C/C++ Source Code Files (*.c)|*.c";
                case GrammarEdit.Core.FilterBuilder.Filters.CPlusPlus_SourceCodeFiles:

                    return "C++ Source Code Files (*.cpp)|*.cpp";
                case GrammarEdit.Core.FilterBuilder.Filters.Java_SourceCodeFiles:

                    return "Java Source Code Files (*.java)|*.java";
                case GrammarEdit.Core.FilterBuilder.Filters.PerlScripts:

                    return "Perl Scripts (*.pl)|*.pl";
                case GrammarEdit.Core.FilterBuilder.Filters.VB_SourceCodeFiles:

                    return "VB Source Code Files (*.vb)|*.vb";
                case GrammarEdit.Core.FilterBuilder.Filters.VisualStudioSolutionFiles:

                    return "Visual Studio Solution Files (*.sln)|*.sln";
                case GrammarEdit.Core.FilterBuilder.Filters.CSharp_SourceCodeFiles:

                    return "C# Source Code Files (*.cs)|*.cs";
                case GrammarEdit.Core.FilterBuilder.Filters.BackupFiles_BAK:

                    return "Backup Files (*.bak)|*.bak";
                case GrammarEdit.Core.FilterBuilder.Filters.BackupFiles_BUP:

                    return "Backup Files (*.bup)|*.bup";
                case GrammarEdit.Core.FilterBuilder.Filters.NortonGhostBackupFiles:

                    return "Norton Ghost Backup Files (*.gho)|*.gho";
                case GrammarEdit.Core.FilterBuilder.Filters.OriginalFiles:

                    return "Original Files (*.ori)|*.ori";
                case GrammarEdit.Core.FilterBuilder.Filters.TemporaryFiles:

                    return "Temporary Files (*.tmp)|*.tmp";
                case GrammarEdit.Core.FilterBuilder.Filters.DiscImageFiles:

                    return "Disc Image Files (*.iso)|*.iso";
                case GrammarEdit.Core.FilterBuilder.Filters.ToastDiscImages:

                    return "Toast Disc Images (*.toast)|*.toast";
                case GrammarEdit.Core.FilterBuilder.Filters.Virtual_CDs:

                    return "Virtual CDs (*.vcd)|*.vcd";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsInstallerPackages:

                    return "Windows Installer Packages (*.msi)|*.msi";
                case GrammarEdit.Core.FilterBuilder.Filters.PartiallyDownloadedFiles:

                    return "Partially Downloaded Files (*.part)|*.part";
                case GrammarEdit.Core.FilterBuilder.Filters.BitTorrentFiles:

                    return "BitTorrent Files (*.torrent)|*.torrent";
                case GrammarEdit.Core.FilterBuilder.Filters.YahooMessengerDataFiles:

                    return "Yahoo! Messenger Data Files (*.yps)|*.yps";
                case GrammarEdit.Core.FilterBuilder.Filters.AllFiles:

                    return "All Files (*.*)|*.*";
                case GrammarEdit.Core.FilterBuilder.Filters.WindowsIcons:

                    return "Windows Icons (*.ico)|*.ico";
                case GrammarEdit.Core.FilterBuilder.Filters.EXIF_ImageFiles:

                    return "Exchangeable Image Format Files (*.exif)|*.exif";
                default:

                    return null;
            }

        }

        #endregion

    }
}