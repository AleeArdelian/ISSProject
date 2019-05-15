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
        PcMemberRepository pcRepo = new PcMemberRepository();
        ChosenPCRepo cpcRepo = new ChosenPCRepo();
        AuthorRepository athRepo = new AuthorRepository();
        ListenerRepository lstRepo = new ListenerRepository();

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

        public string login(string name, string password)
        {
            if(athRepo.hasUsernamePassword(name,password))
            {
                return "Author";
            }
            else if(rmRepo.hasUsernamePassword(name, password))
            {
                return "RegularMember";
            }
            else if(pcRepo.hasUsernamePassword(name, password))
            {
                return "ChairMember";
            }
            else if(lstRepo.hasUsernamePassword(name, password))
            {
                return "Listener";
            }
            return "FAILED";
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
            if (!validateRegister(CNP, username, email)) return false;
            List<ChosenPCMember> allmemb = cpcRepo.FindAll();
            String role = "";
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
                else if (role.Equals("ChairMember"))
                {
                    PcMember pcm = new PcMember();
                    pcm.setCNP(CNP); pcm.setAffiliation(affiliation); pcm.setWebsite(website); pcm.setEmail(email); pcm.setFirstName(firstName);
                    pcm.setLastName(lastName); pcm.setUsername(username); pcm.setPassword(password);
                    pcRepo.Add(pcm);
                }
                return ok;
            }
            else
            {
                if (affiliation != "")
                {
                    Author ath = new Author(CNP, affiliation);
                    ath.setEmail(email); ath.setFirstName(firstName); ath.setLastName(lastName); ath.setPassword(password); ath.setUsername(username);
                    athRepo.Add(ath);
                }
                else
                {
                    Listener lst = new Listener(CNP);
                    lst.setEmail(email); lst.setFirstName(firstName); lst.setLastName(lastName); lst.setPassword(password); lst.setUsername(username);
                    lstRepo.Add(lst);
                }

                return !ok;
            }
        }

        public bool validateRegister(string CNP, string username, string email)
        {
            List<String> athcnp = athRepo.FindCNPs();
            List<String> rmcnp = rmRepo.FindCNPs();
            List<String> lstcnp = lstRepo.FindCNPs();
            List<String> pcmcnp = pcRepo.FindCNPs();

            if (athcnp.Contains(CNP) || rmcnp.Contains(CNP) || lstcnp.Contains(CNP) || pcmcnp.Contains(CNP)) { return false; }
            athcnp = athRepo.FindUsernames();
            rmcnp = rmRepo.FindUsernames();
            lstcnp = lstRepo.FindUsernames();
            pcmcnp = pcRepo.FindUsernames();
            if (athcnp.Contains(username) || rmcnp.Contains(username) || lstcnp.Contains(username) || pcmcnp.Contains(username)) { return false; }
            athcnp = athRepo.FindEmails();
            rmcnp = rmRepo.FindEmails();
            lstcnp = lstRepo.FindEmails();
            pcmcnp = pcRepo.FindEmails();
            if (athcnp.Contains(email) || rmcnp.Contains(email) || lstcnp.Contains(email) || pcmcnp.Contains(email)) { return false; }

            return true;
        }

        
    }
}
