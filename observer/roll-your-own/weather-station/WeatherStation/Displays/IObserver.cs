using System;

namespace WeatherStation {

    public interface IObserver {
        public void update(float temp, float humidity, float pressure);
    }

}