# bubble_trouble
<b>Кратко Објаснување</b><br>
Целта на следнава апликација е да се имплементира едноставна Bubble trouble. Bubble trouble е игра во која треба да се испукаат сите топчиња преку нивно делење со помош на линијата што се испукува од оружјето, пред да истече времето и без да ве допре некое од топчињата.
Линк до играта Bubble trouble : http://www.miniclip.com/games/bubble-trouble/en/ 
<img src="http://i.imgur.com/GTgjM4s.png" alt="Menu" /> </li>
<img src="http://i.imgur.com/KEO6CO8.jpg" alt="Game" /> </li>

<b>Решение на Проблемот</b><br>
Проблемот е решен со користење на 7 форми и 7 класи.
Од формите една е главна форма во која се одвива сликањето на сцената а покрај неа има и посебни форми за менито, упаство за играта,порака за крај на игра, порака за пауза како и модален прозор за напуштање на играта или почнување нова.Во врска со класите најосновна класа е класата Топче која е апстрактна а од неа се изведени мало средно и големо топче.Во нив се чувааат координатите на топчето, неговиот радиус, како и бојата со која би се исцртало.Овие 3 класи се користат за сликаче на топчињата кои играчот би требало да ги испука. Играчот е претсавен со посебна класа со име Играч.Во неа има податоци за координатите, како и 3 слики кои би го анимирале човечето кога се движи лево десно или стои во место.Исто така во оваа класа постои објект од класата Спирала со која е преставено оружјето со кое човечето пука.Во класата Спирала се чувааат листа од точки кои на тајмер се зголемуваат, а главна цел е со нив да се поврзат линии кои би ја анимирале спиралата.Исто така тука пости фукницја која проверува дали некоја од тие точки е во интеракција со некое топче. Освен овие класи постои и класата Документ. Таа е класа во која се одвиваат сцените односно се чуваат сите досегашни податоци.
Како податоци соджи листа од топчиња и објект од класата играч.

<b>Опис на класата Играч</b><br>
Класата играч го претставува човечето кое се движи и ги испукува топчињата. Во неа се содржат инфомации за координатите на човечето, 3 слики кои би го анимирале истото, боолеан променлива за дали е испукано оружјето како и објкект од класата на оружјето односно Спиралата.Неговиот констуруктор прима два аргументи кои ја одредуваат X i Y координатата каде би се исцртало истото.Во него истот така се сетираат и сликите кои се земаат од Resource директорумот.Променливата shooted е поставена на false бидејќи уште ништо не е испукано.Во однос на методите класата содржи методи за движење лево или десно , метод за цртање, метод кој ја  испукува Спиралата, метод за проверка дали човчеето е погодено од топче како и метод за цртање.
Методот кој ја испукува спиралата работи на тој начин што прво проверува дали спиралата е испукана од некој предходен настан и во случај да не е ја иницијализира спиралата на нов објект од истата класа така што поставува 2 почетни точки во нејзината листа.Потоа со секој timer tick се додаваат нови точки па со исцртување на линии меѓу нив се анимира спиралата. Методот за проверка дали човечето е погодено рабботи на тој начин што проверува дали должината на линијата од центарот на човечето кое е квадрат до центарот на даденото топче е помала или поголема од збирот на радиусот на топчето и страната на квадратот.Во случај да е помала враќа true со што понатаму се добива информација дека човчето губи живот.

<b>Упатство за Играње</b><br>

Со користење на стрелките за лево/десно се придвижува човечето во соодветната насока, а со space се испукува линија од оружјето.
Топчињата се делат кога ќе се допрат до линијата испукана од оружјето. Целта е да се испукаат сите топчиња. Доколку некоја топка го допре човечето или истече времето се губи живот. Има 3 животи, доколку сите се изгбат играта завршува. Со пукнување на топче се добива 1 поен, а на крајот на нивото на поените се додава и останатото време. Играта има 3 нивоа.
<img src="http://i.imgur.com/8V5i1gH.png?1" alt="how to play" /> </li>


