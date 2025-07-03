<h1>In The Dark</h1>
<p>Walking through the maze</p>
<ul>
  <li>Android/Oculus Quest 2</li>
  <li>Landscape orientation</li>
</ul>

<h2>Concept:</h2>
<p>The project is a labyrinth-walker in the style of «Dark Echo», using Virtual Reality (VR) technology. </p>

<p>The player needs to get out of the abandoned labyrinth, but the difficulty is that the labyrinth is pitch dark and absolutely nothing can be seen.</p>

<p>Controlling the main character, you need to get to the exit of the labyrinth. The echo of the player's footsteps, which is visualized by rays spreading in different directions and reflecting off obstacles, will help you get out of the impenetrable labyrinth.</p>

<p>At one of the levels, you need to go through a labyrinth using the mechanics of climbing walls, grabbing onto ledges in the wall. You need to collect all the bonuses in this labyrinth and find the exit that appears from the labyrinth.</p>

<p>Upon reaching the finish line, the player completes the maze level and wins.</p>

<h2>Reference and visual style:</h2>
<p>The following serve as references::
  <li>a game project on a similar topic that has the necessary game mechanics: </li></p>
<href>https://store.steampowered.com/app/368650/Dark_Echo/</href>

<p></p>
<figure>
   <img src="./Pictures/Pic_2.png" width="400"/>
   <figcaption>Picture 1 - UI reference (Dark Echo)</figcaption>
  </figure>

<p></p>

<p></p>
<figure>
   <img src="./Pictures/Pic_3.jpeg" width="400"/>
   <figcaption>Picture 2 - Reference Level Design (Dark Echo)</figcaption>
  </figure>
<p></p>

<li> browser game project "3D Maze", which inspired the implementation of one of the game project levels: </li></p>
<href>https://www.chrisraff.com/3d-maze/</href>
<li> game project "THE CLIMB", which inspired the implementation of the mechanics of one of the levels of the game project: </li></p>
<href>https://www.theclimbgame.com/</href>
<li> the science fiction film "Cube", which inspired the implementation of one of the levels of the game project: </li></p>
<href>https://www.kinopoisk.ru/film/20590/?utm_referrer=www.google.com</href>

<p></p>
<figure>
   <img src="./Pictures/Pic_9.png" width="800"/>
   <figcaption>Picture 3 - References for one of the levels of the VR game project</figcaption>
  </figure>
<p></p>
 



<p>However, the current implementation of the project involves 3D visualization:</p>
<ul>
  <li>Start and finish, bonuses, and also the level of the labyrinth.</li>
  <li>The camera is first person and moves with the player.</li>

<p></p>
<figure>
   <img src="./Pictures/Pic_5.png" width="1000"/>
   <figcaption> Picture 4 - Example of camera location </figcaption>
  </figure>
<p></p>
  
<p>The UI is relatively minimalistic, similar to the original, but with buttons.</p>
<p>
<figure>
   <img src="./Pictures/Pic_12.png" width="1000"/>
   <figcaption>Picture 5 - UI of a VR game project</figcaption>
  </figure>
</p>

<p>The visual style of the levels matches the style of Dark Echo: the design of the labyrinth, the recognizable model of sound propagation.</p>

<p>
<figure>
   <img src="./Pictures/Pic_11.png" width="1000"/>
   <figcaption>Picture 6 - 3D models of labyrinth levels of the VR game project</figcaption>
  </figure>
</p>

<p>
<figure>
   <img src="./Pictures/Pic_10.png" width="1000"/>
   <figcaption>Picture 7 - 3D models of additional objects of the VR game project</figcaption>
  </figure>
</p>

<p>
<figure>
   <img src="./Pictures/Pic_13.png" width="1000"/>
   <figcaption>Picture 8 - An example of the implementation of the mechanics of the propagation of "rays of sound waves/echo"</figcaption>
  </figure>
</p>

<h2>Life cycle:</h2>
  <li>1. Запуск/начало игры по нажатию на кнопку «PLAY» в стартовом меню.</li>
  <li>2. Экран с сюжетом/предысторией, описанием управления и кнопкой с переходом к следующему экрану.</li>
  <li>3. Экран с описанием управления и кнопкой с переходом к 1-му уровню с лабиринтом.</li>
  <li>4. Прохождение лабиринта от точки «СТАРТ» до точки «ФИНИШ» и переход на 2-ой уровень.</li>
  <li>5. Прохождение лабиринта от точки «СТАРТ» до точки «ФИНИШ» и сбор бонусов, а также переход на уровень 3.</li>
  <li>6. Прохождение лабиринта от платформы «СТАРТ» до платформы «ФИНИШ» и сбор бонусов.</li>
  <li>7. Игрок выигрывает при успешном достижении платформы «ФИНИШ». Включается экран «CONGRATULATIONS!», на котором предлагается еще раз пройти игру заново по нажатию на кнопку «REPLAY». Происходит переход на пункт 1.
</li>

<h2>Механики и фичи:</h2>
<h3><u>Core-механики:</u></h3>
<ul>
  <li>Игрок перемещается с помощью левого контроллера.</li>
  <li>Игрок поворачивается с помощью правого контроллера.
</li>
  <li>Игрок перемещается по лабиринту, не проходя сквозь его стены.
</li>
  <li>Во время перемещения игрока слышны звуки его шагов.
</li>
  <li>В момент, когда игрок совершает шаг, во время перемещения, от места звука его шага испускаются лучи, эмулирующие распространение звука (звуковых волн) от шага.
</li>
  <li>Отражение лучей звука от препятствий и постепенное их исчезановение.
</li>
    </ul>

<h3><u>Additional-механики:</u></h3>
<ul>
  <li>Игрок собирает бонусы в виде пар обуви для прохождения уровня.
</li>
  <li>При достижении финиша игрок переносится на следующий уровень.

  <li><ul>
    <li>1 уровень – «простое» прохождение лабиринта.
</li>
    <li>2 уровень – чтобы пройти данный уровень, необходимо собрать все бонусы в виде пар обуви.
</li>
 </ul>   
    </ul>

<h3><u>Juice-механики:</u></h3>

  <li>Игрок не может завершить уровень до тех пор, пока не соберет все бонусы.
</li>
<ul>
  <li>Добавление предметов, которые можно перемещать по лабиринту.
</li>
  <li>Добавление нового уровня, в котором присутствует механика перемещения предметов для решения головоломок и прохождения уровней.
</li>
</ul>

<li>Добавлен третий уровень с механикой скалолазанья по стенам/уступам в стенах.
</li>


<h2>Билд:</h2>
<p>Билд проекта можно скачать по следующей ссылке:</p>
<href>https://drive.google.com/file/d/1uy4d0F7j4_yyQJ933fYWsN_HIzMx4mUK/view?usp=sharing</href>
<h2>Демонстрационный видеоролик:</h2>
<href>https://youtu.be/qUt66oXlr00</href>
<h2>Инструкция по запуску (Oculus Quest 2):</h2>
<p>1. Скачать билд (файл формата .apk) проекта по ссылке.</p>
<p>2. Установить на ПК SideQuest (или любую другую программу, позволяющую просматривать файлы директорий VR оборудования), позволяющий загружать в oculus установочные файлы сторонних разработчиков.</p>
<p>3. С помощью SideQuest устновить устновочный файл билда (.apk) в oculus quest 2.</p>
<p>4. После установки приложения, необходимо зайти в настройки VR-гарнитуры во вкладку приложений и выбрать "Неизвестные приложения".</p>
<p>5. Среди неизвестных приложений найти приложение с названием "MAI_VR_Project_DE" и запустить его.</p>
