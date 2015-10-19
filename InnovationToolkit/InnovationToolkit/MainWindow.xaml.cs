using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _365MethodeClassic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TopicHandler myTopicList = new TopicHandler();

        public MainWindow()
        {
            InitializeComponent();
                     

        }

        private void SaveTopic(object sender, RoutedEventArgs e)
        {
            Topic myNewTopic = new Topic(1, TopicSummary.Text.ToString, TopicDescription.Text.ToString);
            myTopicList.AddTopicToList(myNewTopic);

        }

        //private void button_Click(object sender, RoutedEventArgs e)
        //{
        //    string saveCurrentIdeaHere = CurrentIdea.Text;
        //    ThisIsSaved.Text = saveCurrentIdeaHere;
        //}

    }
}
