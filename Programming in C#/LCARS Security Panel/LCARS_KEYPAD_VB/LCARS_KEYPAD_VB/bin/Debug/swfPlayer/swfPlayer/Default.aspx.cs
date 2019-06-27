using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;
public partial class _Default : System.Web.UI.Page
{
    public string swfFileName = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void btnUpload_Click(object sender, EventArgs e)
     {
        if (fUpload.FileContent.Length >0 && IsVaildFile())
        {
            string Path = GetUplaodImagePhysicalPath();
            DirectoryInfo dirUploadImage = new DirectoryInfo(Path);
            if (dirUploadImage.Exists == false)
            {
                dirUploadImage.Create();
            }
            string fileUrl = Path + fUpload.PostedFile.FileName;
            fUpload.PostedFile.SaveAs(fileUrl);
            swfFileName = "image/" + fUpload.PostedFile.FileName;
        }
    }
    private bool IsVaildFile()
    {
        string swfExt = System.IO.Path.GetExtension(fUpload.PostedFile.FileName);
        switch (swfExt)
        {
            case ".swf":
                return true;
            default:
            {
                    lblMsg.Text = "Please select only swf file.";
                    return false;
            }
        }
    }


    
    string GetUplaodImagePhysicalPath()
    {
        return System.Web.HttpContext.Current.Request.PhysicalApplicationPath + "image\\";
    }
  
}
