using System.Net;
using System.Net.Mail;
using System.Configuration;
using System.Net.Configuration;




protected void SendEmail(object sender, EventArgs e)
{
    SmtpSection smtpSection = (SmtpSection)ConfigurationManager.GetSection("system.net/mailSettings/smtp");
    using (MailMessage mm = new MailMessage(smtpSection.From, txtTo.Text.Trim()))
    {
        mm.Subject = txtSubject.Text.Trim();
        mm.Body = txtBody.Text.Trim();
        mm.IsBodyHtml = false;
        SmtpClient smtp = new SmtpClient();
        smtp.Host = smtpSection.Network.Host;
        smtp.EnableSsl = smtpSection.Network.EnableSsl;
        NetworkCredential networkCred = new NetworkCredential(smtpSection.Network.UserName, smtpSection.Network.Password);
        smtp.UseDefaultCredentials = smtpSection.Network.DefaultCredentials;
        smtp.Credentials = networkCred;
        smtp.Port = smtpSection.Network.Port;
        smtp.Send(mm);
        ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('Email sent.');", true);
    }
}