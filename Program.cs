namespace _321Contact120722 {

    class Program {
        //Create struct
        struct Contact {
            public string header;
            public string title;
            public string firstName;
            public string lastName;
            public string address;
            public string city;
            public string state;
            public string ZipCode;

        }//end struct Contact

        static void Main(string[] args) {
            Console.WriteLine();
            int userSelection = 0;

            while (userSelection != 1) {
                userSelection = Menu();
                switch (userSelection) {

                    case 0: { SearchData(); break; }//SearchMode addendum
                    case 1: { SearchResults(); break; }//AddData addendum

                }//end switch

                if (userSelection != 1) {
                    Input("Press enter to go back the menu");
                }//end if
            }//end while
            Console.WriteLine("Thanks for using 3-2-1 Contact");

            static int Menu() {
                int userSelection = 0;
                //PRINT MENU THEN VALIDATE CHOICE
                do {

                    Console.WriteLine("Please make a selection from the menu.");

                    Console.WriteLine("0.  SearchData");
                    Console.WriteLine("1.  SearchResults");
                    Console.WriteLine("2.  Quit");
                    userSelection = int.Parse(Input("Selection:"));
                } while (userSelection < 3 || userSelection > 0);
                //RETURN SELECTION
                return userSelection;
            }//end if

        }//end main

        static string Input(string Prompt) {
            string userSearch = "";
            Console.WriteLine(Prompt + string.Equals(userSearch, "", StringComparison.OrdinalIgnoreCase));//string.Equals is a case insensitive method
            return Console.ReadLine();
        }//end Input function

        //text based function with Read Line to read file
        static string ReadLine() {
            string path = @"C:\Users\ray\Downloads\contacts (1).dat";
            //string data = "";

            //Read data from path file variable
            StreamReader infile = new StreamReader(path);
            //loop until end of data is reached 
            while (infile.EndOfStream == false) {
                //read byte cast from the file cast to a char
                string data = infile.ReadLine();

                //write char to console
                   Console.Write(data);
            }//end while
             //close the file when done
            infile.Close();

            return "";
        }//end ReadLine function with text based methods

        static string SearchData(string[] contacts, string userSearch) {
            bool matches = false;
            int index = 0;

            do {
                //Prompt user to search name
                Input($"Search Name       :    ");
                Console.WriteLine();

            } while (matches == false); //&& index <= contacts.Length - 1);

            if (userSearch == contacts[index] || matches == true) {

                return userSearch;

            }//end if statement

        }//end while

    }//end Search Data function

    static void SearchResult(string [] contacts , string userSearch) {
        //Declare Variables
        string contactsData = "";
        //bool matched = false;

        //Add UNIT SEPARATOR 
        string[] Path = contactsData.Split((char)31, (char)30);

        //Declare type Struct Contact contacts array
        //Create an array type Contact to hold each record
        Contact[] contacts = new Contact[Path.Length];


        //Populate array contacts (incl #(23), \CR(13), \LF(10), US(31), RS(30)
        for (int index = 0; index < Path.Length; index++) {

            //Declare Variable to Get a record
            string currentRecord = Path[index];


            //Split the current record variable
            //char unitSeparator =  //ASCII TABLE HEX VALUE('1F') DECIMAL VALUE (31);
            //char recordSeparator = //ASCII TABLE HEX VALUE('1E') DECIMAL VALUE (30);
            //ADD RECORD SEPARATOR
            string[] fields = currentRecord.Split((char)30);


            //if statement to display execution of search to match all possible contact.dat file matches with user search
            if (contacts[index].firstName == userSearch || contacts[index].lastName == userSearch) {
                Console.WriteLine("     Search Name :  {userSearch} ");
                Console.WriteLine("\n");//create new line
                Console.WriteLine($"    Name        :  {contacts[0].header}23\r\n");
                Console.WriteLine("\n");//create new line
                Console.WriteLine($"    Address     :  {contacts[1].title}31{contacts[1].firstName}31{contacts[1].lastName}31{contacts[1].address}31{contacts[1].city},31{contacts[index].state},31{contacts[index].ZipCode}30");
                Console.WriteLine("\n");//create new line
                //Console.ForegroundColor = ConsoleColor.Red;//list unit separator in red
                //Console.ForegroundColor = ConsoleColor.Blue;//list record separator in red
                Console.WriteLine("\n");//create new line

            }//End if statement

            //Store to Contact Struct with [heading]35# incl no. of files 13\r10\n,[firstName]31,[lastName]31,[address]31,[city]31,[state]31[zipCode]31,[title]30    
            contacts[index].header    = fields[0];
            contacts[index].title     = fields[1];
            contacts[index].firstName = fields[1];
            contacts[index].lastName  = fields[1];
            contacts[index].address   = fields[1];
            contacts[index].city      = fields[1];
            contacts[index].state     = fields[1];
            contacts[index].ZipCode   = fields[1];

            Console.Clear();
        }//end for
    }//end Search Result function
    }//end Program
//end Namespace
