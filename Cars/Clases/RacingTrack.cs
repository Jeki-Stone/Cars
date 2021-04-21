﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Clases
{
    /// <summary>
    /// Трек
    /// Содержит коллекцию машин и запускает, останавливает гонку отрисовывает текущее положение
    /// </summary>
    class RacingTrack
    {
        /// <summary>
        /// Радиус трека для расчёта положения объекта по X и Y на треке
        /// </summary>
        private Graphics graphics;
        /// <summary>
        /// Длина трека
        /// </summary>
        private int trackLength;
        /// <summary>
        /// Радиус трека для расчёта положения объекта по X и Y на треке
        /// </summary>
        private int trackRadius = 160;
        /// <summary>
        /// Координата центра по оси X
        /// </summary>
        private int trackX = 213;
        /// <summary>
        /// Координата центра по оси Y
        /// </summary>
        private int trackY = 213;
        /// <summary>
        /// Длина круга в пикселях
        /// </summary>
        private double l;
        /// <summary>
        /// Масштабный коэффициент пересчёта из Км. в пиксели
        /// </summary>
        private double m;

        /// <summary>
        /// Статус гонки
        /// </summary>
        public bool IsStarted { get; set; }
        /// <summary>
        /// Коллекция машин
        /// </summary>
        public List<ICar> Cars { get; set; }
        /// <summary>
        /// Длина трека
        /// </summary>
        public int TrackLength { get => trackLength; }

        public RacingTrack(Graphics graphics, int trackLength)
        {
            this.graphics = graphics;
           
            SetTrackLength(trackLength);
        }

        /// <summary>
        /// Установить длину трека
        /// </summary>
        /// <param name="length"></param>
        public void SetTrackLength(int length)
        {
            this.trackLength = length;
            // Вычислим длину круга в пикселях
            l = 2 * trackRadius * Math.PI;
            // Вычислим масштабный коэффициент пересчёта из Км. в пиксели
            m = l / trackLength;
        }

        /// <summary>
        /// Запустить гонку
        /// </summary>
        public void Start()
        {
            IsStarted = true;
            foreach (var item in Cars)
                item.Start();
        }

        /// <summary>
        /// Остановить гонку
        /// </summary>
        public void Stop()
        {
            IsStarted = false;
            foreach (var item in Cars)
                item.Stop();
        }

        /// <summary>
        /// Обновляет положение машин на треке, вызывается внешним таймером
        /// </summary>
        public void RefreshPositions()
        {
            //todo Опросить каждую машину о пройденном пути, для вычисления координат на треке
            foreach (var item in Cars)
            {
                // Получить дистанцию машины
                var distance = item.DistanceTraveled;

                // Вычислить координаты машины на треке
                int x = 0, y = 0;
                CalculatePosition(distance, ref x, ref y);

                // Нарисовать машину по заданным координатам
                Draw(item, x, y);
            }
        }

        /// <summary>
        /// Вычисляет координаты машины на треке по пройденной дистанции
        /// </summary>
        /// <param name="distance"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void CalculatePosition(int distance, ref int x, ref int y)
        {
            //todo Найти в интернете формулы расчёта позиции точки на окружности по длине дуги если известен радиус
            // Дистанцию в пикселях
            double d = distance * m;
            // Вычислили координаты на треке
            //координата х = x0 + (R * cos(D/R))
            //координата у = y0 + (R * sin(D/R))
            x = Convert.ToInt32(trackX + (trackRadius * Math.Cos(d / trackRadius)));
            y = Convert.ToInt32(trackY + (trackRadius * Math.Sin(d / trackRadius)));            
        }

        /// <summary>
        /// Отрисовать картинку машины в заданной точке
        /// </summary>
        /// <param name="item"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        private void Draw(ICar item, int x, int y)
        {
            
        }
    }
}
