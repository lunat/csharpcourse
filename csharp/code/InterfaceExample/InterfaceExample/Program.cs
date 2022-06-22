using InterfaceExample;
using InterfaceExample.Animals;
using static System.Console;

Eagle eagle = new Eagle();
eagle.Say();

BlackCat bCat = new BlackCat();
bCat.WitchName = "Morgana";
bCat.Say();

var fido = new Labrador();
WriteLine(fido.Jump(3));

var raul = new Chihuahua();
WriteLine(raul.Jump(3));


WriteLine();
WriteLine();
WriteLine();
//Constructor Injection
var notification = new Notification( 
    new List<IMessage>
    {
        new Email(),
        new Sms(),
        new Push()
    });
notification.Send();

//Property Injection
var notification2 = new NotificationByPropertyInjection();
notification2.SetMessages = new List<IMessage>
{
    new Email(),
    new Sms(),
    new Push()
};
notification2.Send();

//Method|Interface Injection
var notification3 = new NotificationByMethodInjection();
notification3.Send(new List<IMessage>
{
    new Email(),
    new Sms(),
    new Push()
});

//var sendEmail = true;
//var sendSms = false;
//
//if (sendSms)
//{
//    var sms = new Sms();
//    sms.PhoneNumber = "+39..";
//    sms.Message = "My Message";
//    sms.SendSms();
//}
//
//if (sendEmail)
//{
//    var mail = new Email();
//    mail.To = "recipient@gmail.com";
//    mail.Subject = "My Subject";
//    mail.From = "me@gmail.com";
//    mail.Body = "My Message";
//    mail.SendEmail();
//}