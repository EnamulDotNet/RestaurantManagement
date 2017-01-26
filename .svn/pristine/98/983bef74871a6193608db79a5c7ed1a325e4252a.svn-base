using System;
using System.Security.Cryptography;
using System.Text;
using System.Web.Security;
using RMS.BLL;
using RMS.DAL;
using RMS.Model;

namespace RMS.Theme
{
    public partial class Theme : System.Web.UI.MasterPage
    {
        private UserInfo objUserInfo;
        private UserInfoBiz objUserInfoBiz;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SessionUtility.RMSSessionContainer.OBJ_DOC_CLASS = null;
                SessionUtility.RMSSessionContainer.OBJ_CLASS = null;
            }
        }

        protected void bntLogin_OnClick(object sender, EventArgs e)
        {
            ModalUserLogin.Show();
        }

        protected void btnLogin_OnClick(object sender, EventArgs e)
        {
            objUserInfoBiz = new UserInfoBiz();

            objUserInfo = objUserInfoBiz.GetLoginInfo(txtUserName.Text.Trim(), SHA512PasswordGenerator(txtPassword.Text.Trim()));

            if (objUserInfo != null)
            {
                SessionUtility.RMSSessionContainer.OBJ_CLASS = objUserInfo;

                FormsAuthentication.RedirectFromLoginPage(objUserInfo.Username, true);
                Response.Redirect(Session["returnUrl"]?.ToString() ?? "http://localhost:61203/Home.aspx");
            }
            else
            {
                MessageBox("Unauthorized Login");
                SessionUtility.RMSSessionContainer.OBJ_CLASS = null;
            }
        }

        public string SHA512PasswordGenerator(string strInput)
        {
            SHA512 sha512 = new SHA512CryptoServiceProvider();
            byte[] arrHash = sha512.ComputeHash(Encoding.UTF8.GetBytes(strInput));
            StringBuilder sbHash = new StringBuilder();
            for (int i = 0; i < arrHash.Length; i++)
            {
                sbHash.Append(arrHash[i].ToString("x2"));
            }
            return sbHash.ToString();
        }


        public void MessageBox(String message)
        {
            System.Web.UI.WebControls.Label lblMessageBoxForAlert = new System.Web.UI.WebControls.Label();
            lblMessageBoxForAlert.ID = "testjavascriptlabelid";
            lblMessageBoxForAlert.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert(" + "'" + message + "'" + ");</script>";
            Page.Controls.Add(lblMessageBoxForAlert);
        }
    }
}