Отчет по применению SOLID принципов в игре "Угадай число":

1. Принцип единственной ответственности:
   - Класс GameSettings отвечает только за хранение настроек игры.
   - Класс NumberGenerator отвечает за генерацию случайного числа.
   - Класс SettingsLoader отвечает только за загрузку настроек из файла.
   - Класс Game отвечает за управление процессом игры.
   - Классы IUserInterface и его реализация ConsoleUserInterface отвечают за взаимодействие с пользователем.
     
2. Принцип открытости/закрытостb:
     - Классы GameSettings, NumberGenerator, Game, UserInterface открыты для расширения путем добавления новой функциональности или создания новых реализаций интерфейсов без необходимости изменения существующего кода.
     - Например, для расширения функциональности игры можно добавить новый тип генератора чисел или использовать другой способ взаимодействия с пользователем, не меняя существующий код.
       
3. Принцип подстановки Лисков:
     - Мы используем интерфейсы INumberGenerator, IUserInterface для обеспечения заменяемости различными реализациями.
     - Класс Game зависит от интерфейсов, а не конкретных реализаций, что позволяет безболезненно использовать различные классы для генерации чисел или взаимодействия с пользователем.

4. Принцип разделения интерфейсов:
     - Интерфейсы INumberGenerator и IUserInterface содержат минимальный набор методов, не перегруженных функциональностью.
     - Это позволяет классам реализовать только те методы, которые им нужны, и избежать неиспользуемых методов.

5. Принцип инверсии зависимостей:
     - Мы используем инъекцию зависимостей в класс Game, чтобы он зависел от абстракций INumberGenerator и IUserInterface.
     - Это позволяет легко изменять или заменять конкретные реализации INumberGenerator или IUserInterface без изменения кода класса Game.
