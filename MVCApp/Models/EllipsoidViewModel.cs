namespace MVCApp.Models
{
    public class EllipsoidViewModel
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Radius { get; set; }
        //Spheres Number(int) - число шаров планируемое
        public int SpheresNumber { get; set; }
        //NC(double) - концентрация шаров которую мы хотим получить определяется как sum(r_i^3)  / R^3,
        public double NC { get; set; }
        //Размер самого большого(r_i) (double)
        public double Max_r_i { get; set; }
        //Размер самого малого(r_i) (double)
        public double Min_r_i { get; set; }
        //Вид распределения радиусов r_i(комбобокс):-Гаусово-Нормальное-Любое на твоё усмотрение
        public double Distribution_r_i { get; set; }
        //Размер ограничивающей области Rglobal(double)
        public double Rglobal { get; set; }
        //Тип ограничивающей области(комбобокс:сфера, куб )
        public string BoundingArea { get; set; }
        //Тип распределения для генерации x,y,z центров(комбобокс:Гамма, Гаусово, рядом будут расположены дополнительные поля для ввода shape(double), scale(double) по которым будет происходить генерация)
        public string GenerateCentreCoords { get; set; }
        public double Shape { get; set; }
        public double Scale { get; set; }
        //Число файлов(int) (т.е. сколько раз мы хотим осуществить генерацию)
        public int NumberOfFiles { get; set; }
        //try_count Число попыток запихнуть шар в систему(если не лезет) - (int)
        public int try_count { get; set; }
        //excess доп параметр , по умолчанию excess = 1.005 (double)
        public double excess = 1.005;
    }
}
