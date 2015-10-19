using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _365MethodeClassic
{
    class Topics
    {
        private int topicId { set; get; }
        private string topicSummary { set; get; }
        private string topicDescription { set; get; }

        Topics(int _topicId, string _topicSummary, string _topicDescription)
        {
            this.topicId = _topicId;
            this.topicSummary = _topicSummary;
            this.topicDescription = _topicDescription;

        }
    }
}
