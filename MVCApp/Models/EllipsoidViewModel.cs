namespace MVCApp.Models
{
    public class EllipsoidViewModel
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double radius { get; set; }
        //spheres number(int) - число шаров планируемое
        public int spheresnumber { get; set; }
        //nc(double) - концентрация шаров которую мы хотим получить определяется как sum(r_i^3)  / r^3,
        public double nc { get; set; }
        //размер самого большого(r_i) (double)
        public double max_r_i { get; set; }
        //размер самого малого(r_i) (double)
        public double min_r_i { get; set; }
        //вид распределения радиусов r_i(комбобокс):-гаусово-нормальное-любое на твоё усмотрение
        public double distribution_r_i { get; set; }
        //размер ограничивающей области rglobal(double)
        public double rglobal { get; set; }
        //тип ограничивающей области(комбобокс:сфера, куб )
        public string? boundingarea { get; set; }
        //тип распределения для генерации x,y,z центров(комбобокс:гамма, гаусово, рядом будут расположены дополнительные поля для ввода shape(double), scale(double) по которым будет происходить генерация)
        public string? generatecentrecoords { get; set; }
        public double shape { get; set; }
        public double scale { get; set; }
        //число файлов(int) (т.е. сколько раз мы хотим осуществить генерацию)
        public int numberoffiles { get; set; }
        //try_count число попыток запихнуть шар в систему(если не лезет) - (int)
        public int try_count { get; set; }
        //excess доп параметр , по умолчанию excess = 1.005 (double)
        public double excess = 1.005;
    }
}
