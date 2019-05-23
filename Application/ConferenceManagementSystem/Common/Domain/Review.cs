using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    public class Review
    {
        public string Qualifier { get; set; }
        public string Comments { get; set; }
        public string ReviewerCNP { get; set; }
        public int PaperID { get; set; }

        public Review(string Qualifier, string Comments, string ReviewerCNP, int PaperID)
        {
            this.Qualifier = Qualifier;
            this.Comments = Comments;
            this.ReviewerCNP = ReviewerCNP;
            this.PaperID = PaperID;
        }

        public string getQualifier() { return Qualifier; }
        public string getComments() { return Comments; }
        public string getReviewerCNP() { return ReviewerCNP; }
        public int getPaperID() { return PaperID; }
        public void setQualifier(string Qualifier) { this.Qualifier = Qualifier; }
        public void setComments(string Comments) { this.Comments = Comments; }
        public void setReviewerCNP(string ReviewerCNP) { this.ReviewerCNP = ReviewerCNP; }
        public void setPaperID(int PaperID) { this.PaperID = PaperID; }
    }
}
