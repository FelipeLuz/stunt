using stunt.Models;

namespace stunt.Mock;
public static class Data
{
	public static List<Request> Requests => new List<Request>
    {
        new Request { Id = 1, Name = "Felipe L.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Blumenau" },
        new Request { Id = 2, Name = "Filipi C.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Itajai" },
        new Request { Id = 3, Name = "Maria A.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "UFSC", CityOfDestination = "Florianópolis" },
        new Request { Id = 4, Name = "Bruno V.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Joinville" },
        new Request { Id = 5, Name = "Carla P.", Status = RequestStatus.Processed, ImageUrl = "student.png", University = "Unisul", CityOfDestination = "Tubarão" },
        new Request { Id = 6, Name = "Rafael M.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "UFSC", CityOfDestination = "São José" },
        new Request { Id = 7, Name = "Larissa S.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Itapema" },
        new Request { Id = 8, Name = "Eduardo R.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "UDESC", CityOfDestination = "Joinville" },
        new Request { Id = 9, Name = "Patricia L.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "Unisul", CityOfDestination = "Imbituba" },
        new Request { Id = 10, Name = "Lucas G.", Status = RequestStatus.Processed, ImageUrl = "student.png", University = "UFSC", CityOfDestination = "Florianópolis" },
        new Request { Id = 11, Name = "Amanda R.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Balneário Camboriú" },
        new Request { Id = 12, Name = "Felipe S.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "UDESC", CityOfDestination = "Joinville" },
        new Request { Id = 13, Name = "Juliana M.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "Unisul", CityOfDestination = "Tubarão" },
        new Request { Id = 14, Name = "Rodrigo C.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "UFSC", CityOfDestination = "Florianópolis" },
        new Request { Id = 15, Name = "Camila B.", Status = RequestStatus.Processed, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Itajaí" },
        new Request { Id = 16, Name = "Thiago M.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "UDESC", CityOfDestination = "Florianópolis" },
        new Request { Id = 17, Name = "Isabela L.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Balneário Camboriú" },
        new Request { Id = 18, Name = "Marcelo F.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "UFSC", CityOfDestination = "Joinville" },
        new Request { Id = 19, Name = "Leticia P.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "Unisul", CityOfDestination = "Tubarão" },
        new Request { Id = 20, Name = "Gustavo A.", Status = RequestStatus.Processed, ImageUrl = "student.png", University = "UDESC", CityOfDestination = "São José" },
        new Request { Id = 21, Name = "Natalia G.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Itapema" },
        new Request { Id = 22, Name = "André L.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "UFSC", CityOfDestination = "Florianópolis" },
        new Request { Id = 23, Name = "Luisa M.", Status = RequestStatus.Incoming, ImageUrl = "student.png", University = "Univali", CityOfDestination = "Itajaí" },
        new Request { Id = 24, Name = "Ricardo S.", Status = RequestStatus.Processing, ImageUrl = "student.png", University = "Unisul", CityOfDestination = "Imbituba" },
        new Request { Id = 25, Name = "Fernanda C.", Status = RequestStatus.Processed, ImageUrl = "student.png", University = "UDESC", CityOfDestination = "Florianópolis" }
    };
}