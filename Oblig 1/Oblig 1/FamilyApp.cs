using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Oblig_1
{
    public class FamilyApp
    {

        public List<Person> PersonList;

        public FamilyApp(params Person[] peoples)
        {
            PersonList =new List<Person>(peoples);
        }

        public string WelcomeMessage()
        {
            return "Welcome to the family tree console application, please enjoy your stay !";
        }

        public string CommandPrompt = "Enter Text Here: ";


        public string HandleCommand(string command)
        {
            string mainCommand = command;

            if (mainCommand.ToLower() == "help")
            {
                return "Type 'help' for a list of commands.\n" +
                       "'list' to see a list of registered persons\n" +
                       "'show <id> to show the registered person with that id.";
            }
            
            if (mainCommand.ToLower() == "list")
            {

                string listAttr = "";

                foreach (var peoples in PersonList)
                {
                    listAttr += peoples.GetDescription() + "\n";
                }

                return listAttr;
            }

            if (mainCommand.Substring(0,4).ToLower() == "show")
            {
                int idNumber = Int32.Parse(mainCommand.Substring(5));
                return FindFamilyMember(idNumber);
            }

            return "Please input a valid keyword or type 'help' for more info";
        }

        public string FindFamilyMember(int idNumber)
        {
            string infoResult;

;           foreach (var PersonSearch in PersonList)
            {
                if (PersonSearch.Id == idNumber)
                {
                    infoResult = PersonSearch.GetDescription();
                    infoResult += ChildSearch(idNumber);
                    return infoResult;
                }
            }

            infoResult = "Could not find the person you are searching for, please try again...";
            return infoResult;
        }

        public string ChildSearch(int idNumber)
        {
            int NumOFChildren = PersonList.Count;
            string[] idList = new string[NumOFChildren];
            string child = null;
            int iterations = 0;

            for (int a = 0; a < NumOFChildren; a++)
            {
                if (PersonList[a].Mother != null && PersonList[a].Mother.Id == idNumber)
                {
                    idList[iterations] = " " + PersonList[a].FirstName + " <Id= " + PersonList[a].Id + "> Born: " + PersonList[a].BirthYear;
                    iterations++;
                }
                else if (PersonList[a].Father != null && PersonList[a].Father.Id == idNumber)
                {
                    idList[iterations] = " " + PersonList[a].FirstName + " <Id= " + PersonList[a].Id + "> Born: " + PersonList[a].BirthYear;
                    iterations++;
                }
            }
            if (idList[0] != null)
            {
                child = " Children:";
                for (int i = 0; i < idList.Length; i++)
                {
                    if (idList[i] != null)
                    {
                        child += idList[i];
                    }
                }
            }

            else if (idList[0] == null)
            {
                child = " ";
            }


            return child;
        }
    }
}


