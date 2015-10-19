using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _365MethodeClassic
{
    class TopicHandler
    {
        private List<Topics> listOfTopics { get; set;}

        public void AddTopicToList(Topics topicToAdd)
        {
            this.listOfTopics.Add(topicToAdd);                        
        }

        public List<Topics> GetlistOfTopics()
        {
            return listOfTopics;
        }

    }
}
