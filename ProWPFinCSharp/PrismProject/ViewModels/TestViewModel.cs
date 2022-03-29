using PrismProject.Models;
using Prism.Mvvm;

namespace PrismProject.ViewModels {
    class TestViewModel : BindableBase {

        private TestModel _testModel;

        public TestViewModel() {
            _testModel = new TestModel();
            _testModel.Message = "This is prism example";
        }

        public TestModel TestModel {
            get { return _testModel; }
            set { SetProperty(ref _testModel, value); }
        }
    }
}
