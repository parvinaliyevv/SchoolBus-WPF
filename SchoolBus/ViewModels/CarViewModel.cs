﻿namespace SchoolBus.ViewModels;

public class CarViewModel
{
    private readonly SchoolBusDbContext _dbContext;

    public ObservableCollection<Car> Cars { get; set; }


    public CarViewModel()
    {
        _dbContext = DI_Container.Container.Resolve<SchoolBusDbContext>();

        Cars = new(_dbContext.Cars.Include("Driver"));
    }
}
