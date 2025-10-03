using collections_app_1.Models;

namespace collections_app_1.DbContext
{
    public class AcademyContext
    {
        public static IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book { Id = 1, Title = "Africa Must Unite" },
                new Book { Id = 2, Title = "Long Walk to Freedom" },
                new Book { Id = 3, Title = "Unbowed: A Memoir" },
                new Book { Id = 4, Title = "Things Fall Apart" },
                new Book { Id = 5, Title = "The Joys of Motherhood" },
                new Book { Id = 6, Title = "So Long a Letter" },
                new Book { Id = 7, Title = "God’s Bits of Wood" },
            };
        }
        public static IEnumerable<Student> GetStudents()
        {
            return new List<Student>()
            {
            new Student
            {
                Id = 1,
                Name = "Kwame Nkrumah",
                Books = new List<Book>
                {
                    new Book { Id = 1, Title = "Africa Must Unite" },
                    new Book { Id = 2, Title = "Consciencism" }
                }
            },
            new Student
            {
                Id = 2,
                Name = "Nelson Mandela",
                Books = new List<Book>
                {
                    new Book { Id = 3, Title = "Long Walk to Freedom" }
                }
            },
            new Student
            {
                Id = 3,
                Name = "Haile Selassie",
                Books = new List<Book>
                {
                    new Book { Id = 4, Title = "Selected Speeches of Haile Selassie" }
                }
            },
            new Student
            {
                Id = 4,
                Name = "Wangari Maathai",
                Books = new List<Book>
                {
                    new Book { Id = 5, Title = "Unbowed: A Memoir" }
                }
            },
            new Student
            {
                Id = 5,
                Name = "Chinua Achebe",
                Books = new List<Book>
                {
                    new Book { Id = 6, Title = "Things Fall Apart" },
                    new Book { Id = 7, Title = "No Longer at Ease" }
                }
            },
            new Student
            {
                Id = 6,
                Name = "Yaa Asantewaa",
                Books = new List<Book>
                {
                    new Book { Id = 8, Title = "The Warrior Queen" }
                }
            },
            new Student
            {
                Id = 7,
                Name = "Thomas Sankara",
                Books = new List<Book>
                {
                    new Book { Id = 9, Title = "We Are the Heirs of the World's Revolutions" }
                }
            },
            new Student
            {
                Id = 8,
                Name = "Miriam Makeba",
                Books = new List<Book>
                {
                    new Book { Id = 10, Title = "Makeba: My Story" }
                }
            },
            new Student
            {
                Id = 9,
                Name = "Didier Drogba",
                Books = new List<Book>
                {
                    new Book { Id = 11, Title = "Commitment: My Autobiography" }
                }
            },
            new Student
            {
                Id = 10,
                Name = "Ellen Johnson Sirleaf",
                Books = new List<Book>
                {
                    new Book { Id = 12, Title = "This Child Will Be Great" }
                }
            },
            new Student
            {
                Id = 11,
                Name = "Salif Keita",
                Books = new List<Book>
                {
                    new Book { Id = 13, Title = "An African Voice" }
                }
            },
            new Student
            {
                Id = 12,
                Name = "Amílcar Cabral",
                Books = new List<Book>
                {
                    new Book { Id = 14, Title = "Unity and Struggle" }
                }
            },
            new Student
            {
                Id = 13,
                Name = "Fela Kuti",
                Books = new List<Book>
                {
                    new Book { Id = 15, Title = "Fela: This Bitch of a Life" }
                }
            },
            new Student
            {
                Id = 14,
                Name = "Leila Aboulela",
                Books = new List<Book>
                {
                    new Book { Id = 16, Title = "Minaret" },
                    new Book { Id = 17, Title = "The Translator" }
                }
            },
            new Student
            {
                Id = 15,
                Name = "Mohamed Salah",
                Books = new List<Book>
                {
                    new Book { Id = 18, Title = "Mo Salah: The Egyptian King" }
                }
            },
            new Student
            {
                Id = 16,
                Name = "Ousmane Sembène",
                Books = new List<Book>
                {
                    new Book { Id = 19, Title = "God's Bits of Wood" }
                }
            },
            new Student
            {
                Id = 17,
                Name = "Trevor Noah",
                Books = new List<Book>
                {
                    new Book { Id = 20, Title = "Born a Crime" }
                }
            },
            new Student
            {
                Id = 18,
                Name = "Kofi Annan",
                Books = new List<Book>
                {
                    new Book { Id = 21, Title = "Interventions: A Life in War and Peace" }
                }
            },
            new Student
            {
                Id = 19,
                Name = "Alek Wek",
                Books = new List<Book>
                {
                    new Book { Id = 22, Title = "Alek: From Sudanese Refugee to International Supermodel" }
                }
            },
            new Student
            {
                Id = 20,
                Name = "Desmond Tutu",
                Books = new List<Book>
                {
                    new Book { Id = 23, Title = "No Future Without Forgiveness" }
                }
            }
            };
        }
    }
}
