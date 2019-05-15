using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Paper
    {
        public String Content { get; set; }
        public String Abstract { get; set; }
        public String PaperName { get; set; }
        public String Topic { get; set; }
        public int isAccepted { get; set; }

        public Paper() { }

        public String getContent() { return Content; }
        public void setContent(String Content) { this.Content = Content; }
        public String getAbstract() { return Abstract; }
        public void setAbstract(String Abstract) { this.Abstract = Abstract; }
        public String getPaperName() { return PaperName; }
        public void setPaperName(String PaperName) { this.PaperName = PaperName; }
        public String getTopic() { return Topic; }
        public void setTopic(String Topic) { this.Topic = Topic; }
        public int getStatus() { return isAccepted; }
        public void setStatus(int isAccepted) { this.isAccepted = isAccepted; }
    }
}
