using Common.Domain;
using Common.Service;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Service
{
    class CMSService : MarshalByRefObject, IService
    {
        ConferenceRepository confRepo = new ConferenceRepository();
        RegularMemberRepository rmRepo = new RegularMemberRepository();
        ChosenPCRepo cpcRepo = new ChosenPCRepo();

        public void AddConference(int ConferenceId, string ConferenceName)
        {
            confRepo.Add(new Conference(ConferenceId, ConferenceName));
        }

        public Conference GetConferences()
        {
            return confRepo.FindOne(new Conference(2, "asd"));
        }

        public void AddAuthor(long CNP, string affiliation)
        {
            throw new NotImplementedException();
        }

        public void AddListener(string CNP)
        {
            throw new NotImplementedException();
        }

        public void AddParticipant(string Username, string Password, string FirstName, string LastName, string Email)
        {
            throw new NotImplementedException();
        }

        public void AddRegularMember(string CNP, string Affiliation, string Website, string FirstName, string LastName, string email, string Username, string Password)
        {
            RegularMember rm = new RegularMember(CNP, Affiliation, Website);
            rm.setEmail(email); rm.setFirstName(FirstName); rm.setLastName(LastName); rm.setUsername(Username); rm.setPassword(Password);
            rmRepo.Add(rm);
        }

        public void AddSpeaker(string CNP, string affiliation, string username, string password, string firstName, string lastName, string email)
        {
            throw new NotImplementedException();
        }

        public List<Listener> FindAllListeners()
        {
            throw new NotImplementedException();
        }

        public bool login(string name, string password)
        {
            // check if credentials are in the database
            // return true if there are, false otherwise
            return false;
        }

        public void UpdateAuthor(long CNP, string affiliation)
        {
            throw new NotImplementedException();
        }

        public void UpdateListener(string CNP)
        {
            throw new NotImplementedException();
        }

        public void UpdateParticipant(string Username, string Password, string FirstName, string LastName, string Email)
        {
            throw new NotImplementedException();
        }

        public void UpdatePcMember(string CNP, string Affiliation, string Website)
        {
            throw new NotImplementedException();
        }

        public void UpdateSpeaker(string CNP, string affiliation, string username, string password, string firstName, string lastName, string email)
        {
            throw new NotImplementedException();
        }

        public bool register(string firstName, string lastName, string CNP, string affiliation, string website, string email, string username, string password)
        {
            List<ChosenPCMember> allmemb = cpcRepo.FindAll();
            String role="";
            bool ok = false;
            foreach (ChosenPCMember x in allmemb)
            {
                if (x.getCNP() == CNP)
                {
                    ok = true;
                    role = x.getPCRole();
                }
            }

            if (ok)
            {
                if (role.Equals("RegularMember")) {
                    RegularMember rm = new RegularMember(CNP, affiliation, website);
                    rm.setEmail(email); rm.setFirstName(firstName); rm.setLastName(lastName); rm.setUsername(username); rm.setPassword(password);
                    rmRepo.Add(rm);
                }
                return ok;
            }
            else
            {
                return !ok;
            }
        }
    }
}
