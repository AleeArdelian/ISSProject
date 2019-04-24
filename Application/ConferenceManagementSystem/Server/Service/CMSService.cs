using Common.Domain;
using Common.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Service
{
    class CMSService : MarshalByRefObject, IService
    {
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

        public void AddPcMember(string CNP, string Affiliation, string Website)
        {
            throw new NotImplementedException();
        }

        public void AddSpeaker(string CNP, string affiliation, string username, string password, string firstName, string lastName, string email)
        {
            throw new NotImplementedException();
        }

        public List<Listener> FindAllListeners()
        {
            throw new NotImplementedException();
        }

        public void Login(string Nume, string Parola)
        {
            throw new NotImplementedException();
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
    }
}
