using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _365MethodeClassic
{
    class TopicHandler
    {
        private List<Topic> listOfTopic { get; set;}

        public TopicHandler()
        {
            listOfTopic = new List<Topic>();
        }
        public void AddTopicToList(Topic topicToAdd)
        {
            this.listOfTopic.Add(topicToAdd);                        
        }

        public List<Topic> GetListOfTopics()
        {
            return listOfTopic;
        }

    }
}
