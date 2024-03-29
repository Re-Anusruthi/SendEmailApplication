﻿namespace EmailApplication.Domain
{
    public class SMTPConfig
    {
        public string FromMailId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public int TimeOut { get; set; }
    }
}