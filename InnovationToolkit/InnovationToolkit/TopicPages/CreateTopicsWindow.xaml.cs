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

namespace InnovationToolKit
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class CreateTopicsWindow : Window
    {
        private TopicHandler myTopicList = new TopicHandler();
        public CreateTopicsWindow()
        {
            InitializeComponent();
        }
        
        private void SaveTopic(object sender, RoutedEventArgs e)
        {
            Topic myNewTopic = new Topic(1, TopicSummary.Text, TopicDescription.Text);
            myTopicList.AddTopicToList(myNewTopic);
            TopicSummary.Text = "";
            TopicDescription.Text = "";
        }

        private void ShowSavedTopic(object sender, RoutedEventArgs e)
        {
            MySavedTopicsTextBlock.Text = "";
            foreach (Topic topic in myTopicList.GetListOfTopics())
            {
                MySavedTopicsTextBlock.Text = MySavedTopicsTextBlock.Text + " - " + topic.GetTopicSummary() + " - " + topic.GetTopicDescription() + "\n";
            }
        }
    }
}
