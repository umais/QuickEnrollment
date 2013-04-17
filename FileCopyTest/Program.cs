using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using QuickEnrollment.Infrastructure;
using EnrollmentClassLibrary;
using Ninject;
using System.Net;
using System.IO.Compression;
namespace FileCopyTest
{
    class Program
    {
        static void Main(string[] args)
        {

            //IKernel k = new StandardKernel(new NinjectTransactionModule());

            Upload(@"C:\Projects\OdataWebAPI.txt","192.168.1.11","Umais","123");

            //ITransaction t = k.Get<ITransaction>();

            //ValidateEnrollment v = new ValidateEnrollment(t);
            //v.printTransaction();
            //string filename=@"C:\Users\ATX\Desktop\i-9.pdf";
            //DirectoryInfo d = new DirectoryInfo(@"C:\Users\ATX\Desktop");
            //FileInfo[] a=d.GetFiles();

            //foreach (FileInfo f in a)
            //{
            //    String CreationTime;
              
            //}
            //File.Copy(filename,@"C:\fileCopy\i9.pdf");
        }

        static void Upload(string filename,string ftpServerIP,string ftpUserID,string ftpPassword)
{
  FileInfo fileInf = new FileInfo(filename);
  string uri = "ftp://" + ftpServerIP + "/" + fileInf.Name;
  FtpWebRequest reqFTP;
    
  // Create FtpWebRequest object from the Uri provided
  reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(
            "ftp://" + ftpServerIP + "/" + fileInf.Name));

  // Provide the WebPermission Credintials
  reqFTP.Credentials = new NetworkCredential(ftpUserID, 
                                             ftpPassword);
    
  // By default KeepAlive is true, where the control connection is 
  // not closed after a command is executed.
  reqFTP.KeepAlive = false;

  // Specify the command to be executed.
  reqFTP.Method = WebRequestMethods.Ftp.UploadFile;
    
  // Specify the data transfer type.
  reqFTP.UseBinary = true;

  // Notify the server about the size of the uploaded file
  reqFTP.ContentLength = fileInf.Length;

  // The buffer size is set to 2kb
  int buffLength = 2048;
  byte[] buff = new byte[buffLength];
  int contentLen;
    
  // Opens a file stream (System.IO.FileStream) to read 
  //the file to be uploaded
  FileStream fs = fileInf.OpenRead();
   
  try
  {
        // Stream to which the file to be upload is written
        Stream strm = reqFTP.GetRequestStream();
        
        // Read from the file stream 2kb at a time
        contentLen = fs.Read(buff, 0, buffLength);
        
        // Till Stream content ends
        while (contentLen != 0)
        {
            // Write Content from the file stream to the 
            // FTP Upload Stream
            strm.Write(buff, 0, contentLen);
            contentLen = fs.Read(buff, 0, buffLength);
        }
        
        // Close the file stream and the Request Stream
        strm.Close();
        fs.Close();
  }
  catch(Exception ex)
    {
        Console.WriteLine(ex.Message, "Upload Error");
    }
}

    }
}
