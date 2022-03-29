using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace PrismProject.Models {
    class TestModel : BindableBase {
        private string _message;

        public string Message {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
    }
}
