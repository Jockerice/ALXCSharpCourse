using ALXCSharpCourse.Enums;
using ALXCSharpCourse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALXCSharpCourse.Demo
{
    public class EnumsDemo
    {
     

        public static void Run()
        {
            EmailMessage message = new EmailMessage
                ("jankowal@wp",
                 "mmalinow@gmail.com",
                 "Sprzedam opla",
                 MessageStatus.DRAFT
                 );

            message.ChangeStatus(MessageStatus.SENT);
            message.ChangeStatus(MessageStatus.DRAFT);
            message.ChangeStatus(MessageStatus.PENDING);
            message.ChangeStatus(MessageStatus.SERVCIE_FAULT);


        }

    }

 }

    
