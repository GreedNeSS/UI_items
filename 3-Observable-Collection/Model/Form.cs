using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace _3_Observable_Collection.Model
{
    public class Form : INotifyPropertyChanged
    {
        string _icon;

        public string Icon 
        {
            get { return _icon; }
            set
            {
                switch (value)
                {
                    case "1":
                        _icon = "Assets/01.png";
                        break;

                    case "2":
                        _icon = "Assets/02.png";
                        break;

                    default: _icon = "Assets/03.png";
                        break;
                }
            }
        }

        public string FirstName { get; set; }
        public string Completion { get;set; }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
