public class Car
{
    public int Id;
    public string Brand;
    public string Model;
    public bool IsElectric;
    public int MaxSpeedKmh;
    public int AutonomyKm;
}
public class CarRepository
{
    public static List<Car> GetAll()
    {
        return new List<Car>
        {
            new Car { Id = 1, Brand = "Dacia", Model = "Spring", IsElectric = true, AutonomyKm = 300, MaxSpeedKmh = 120 },
            new Car { Id = 2, Brand = "VW", Model = "Polo", IsElectric = false, AutonomyKm = 850, MaxSpeedKmh = 180 },
            new Car { Id = 3, Brand = "Ford", Model = "Focus", IsElectric = false, AutonomyKm = 950, MaxSpeedKmh = 210 },
            new Car { Id = 4, Brand = "Tesla", Model = "Model 3", IsElectric = true, AutonomyKm = 500, MaxSpeedKmh = 260 },
            new Car { Id = 5, Brand = "Opel", Model = "Astra", IsElectric = false, AutonomyKm = 1010, MaxSpeedKmh = 190 }
        };
    }
}

public class CarService
{
    private CarRepository carRepository;

    public CarService(CarRepository carRepository)
    {
        this.carRepository = carRepository;
    }
    public List<Car> GetHighSpeedCars()
    {
        List<Car> cars = CarRepository.GetAll();
        List<Car> highSpeedCars = new List<Car>();

        foreach (Car car in cars)
        {
            if (car.MaxSpeedKmh > 180)
            {
                highSpeedCars.Add(car);
            }
        }

        return highSpeedCars;
    }
    public List<Car> GetAutonomyCars()
    {
        List<Car> cars = CarRepository.GetAll();
        List<Car> autonomiemare = new List<Car>();

        foreach (Car car in cars)
        {
            if (car.AutonomyKm > 180)
            {
                autonomiemare.Add(car);
            }
        }

        return autonomiemare;

    }
    public int NumarMasini()
    {

        int k = 0;

        foreach (Car car in CarRepository.GetAll())
        {
            if (car.MaxSpeedKmh >= 100 && car.MaxSpeedKmh <= 200)
            {
                k++;
            }
        }

        return k;


    }
    public List<Car> GetAllCars()
    {
        return CarRepository.GetAll();
    }
}