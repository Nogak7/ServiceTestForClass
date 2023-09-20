//using ServiceTest.Models;
using ServiceTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ServiceTest.ViewModels
{
    public class MainPageViewModel:ViewModel
    {
        public ICommand GetMessage { get; protected set; }  
        public string Text  { get { return text; } set { if (text != value) { text = value; OnPropertyChange(); } } }
        private string text ; 
        private TriviaService TriviaService { get; set; }

        
        public MainPageViewModel(TriviaService triviaService)
        {
            TriviaService = triviaService;
            GetMessage = new Command(async () => Text = await());
            {
                
            };
        }

       


    }
}
