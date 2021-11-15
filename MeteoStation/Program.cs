{
    MeteoStation.WeatherData weatherData = new MeteoStation.WeatherData();


    MeteoStation.ModuleData pogoda = new MeteoStation.ModuleData( weatherData ); 

   // weatherData.RegisterObserver(pogoda);
    weatherData.SetReadings(29.31f, 79.5f, float.MaxValue);

    //pogoda.Display();


    
}