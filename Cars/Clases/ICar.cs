using System;

namespace Cars.Clases
{
    /// <summary>
    /// Интерфейс реализует общие свойства и методы для всех классов машин
    /// каждый класс который наследует этот интерфейс должен содержать реализацию этих свойств и методов
    /// </summary>
    interface ICar
    {
        /// <summary>
        /// Статус сломан
        /// </summary>
        bool IsBroken { get; }
        /// <summary>
        /// Шанс поломки %
        /// </summary>
        int ChanceBreakage { get; }
        /// <summary>
        /// Пройденная дистанция
        /// </summary>
        float DistanceTraveled { get; }
        /// <summary>
        /// Путь к изображению
        /// </summary>
        string PathImg { get; }
        /// <summary>
        /// Тип машины
        /// </summary>
        string TransportType { get; }
        /// <summary>
        /// Скорость Км/ч
        /// </summary>
        int Speed { get; }
        /// <summary>
        /// Статус что двигается
        /// </summary>
        bool IsRun { get; }
        /// <summary>
        /// Время поломки, нужно для вычесления простоя
        /// </summary>
        DateTime? TimeBroken { get; }
        /// <summary>
        /// Время начала движения
        /// </summary>
        DateTime TimeStart { get; }
        /// <summary>
        /// Время остановки
        /// </summary>
        DateTime? TimeStop { get; }
        /// <summary>
        /// Время завершения ремонта
        /// </summary>
        DateTime? RepairСompletionTime { get; }
        /// <summary>
        /// Время простоя
        /// </summary>
        int DownTime { get; }
        /// <summary>
        /// Запустить машину
        /// </summary>
        void Start();
        /// <summary>
        /// Остановить машину
        /// </summary>
        void Stop();
        /// <summary>
        /// Останавливает машину по прибытию на финиш
        /// </summary>
        void Stop(int trackLength);
        /// <summary>
        /// Вычислить пройденный путь
        /// </summary>
        /// <returns></returns>
        float CalculatTheDistanceTraveled();
        /// <summary>
        /// Машина перерисовывает себя на новые координаты
        /// </summary>
        void Draw(int x, int y);
        /// <summary>
        /// CalculatingTheChanceOfBreakage
        /// </summary>
        void CalculatingTheChanceOfBreakage();
        /// <summary>
        /// Удаляет картинку машинки с трека
        /// </summary>
        void Dispose();
    }
}