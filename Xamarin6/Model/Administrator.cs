using System;
using System.Collections.Generic;
using System.Text;

namespace Xamarin6.Model
{
    internal class Administrator
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Identification { get; set; }
		public string Age { get; set; }
		public string Company { get; set; }
        public string PhoneNumber { get; set; }
		public string Adress { get; set; }
		public string Email { get; set; }
        public string Date { get; set; }
		public string Huella { get; set; }
		public string Foto { get; set; }		
        public string Qr { get; set; }
    }
}
