   M S B A M L   `   `   `  ���� K  GPostgreSQL-Study, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PostgreSQL_Study.ViewPostgreSQL_Study.View  $    PostgreSQL_Study.View.Settings   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:PostgreSQL_Study.View       N� Title$  Settings��.��� $��40,30q� � RowDefinitions �� $
��Auto ��� �� $
��Auto �.+��� $��Настройки��$	��Top=�$
��Left=�$
��Auto��$
��Auto��$��20(�$��0����  �� Orientation$ 
Horizontal=�$��1��.+��� .+��� $��Имя сервера��$	��Top=�$
��Left=�$
��Auto��$
��Auto��$��16(�$��0,30,0,0q��� -    ��Name$ 
ServerName��$	��200��$��20��$��Center=�$
��Left=�$��5,0,0,0q��� $��Порт сервера��$	��Top=�$
��Left=�$
��Auto��$
��Auto��$��16(�$��0,15,0,0q��� -   $ 
ServerPort��$	��200��$��20��$��Center=�$
��Left=�$��5,0,0,0q��� $"��Имя базы данных��$	��Top=�$
��Left=�$
��Auto��$
��Auto��$��16(�$��0,15,0,0q��� -   $ DatabaseName��$	��200��$��20��$��Center=�$
��Left=�$��5,0,0,0q��� $��80,0,0,0q�.+��� $%��Имя пользователя��$	��Top=�$
��Left=�$
��Auto��$
��Auto��$��16(�$��0,30,0,0q��� -   $ UserName��$	��200��$��20��$��Center=�$
��Left=�$��5,0,0,0q��� $��Пароль��$	��Top=�$
��Left=�$
��Auto��$
��Auto��$��16(�$��0,30,0,0q��� -   $ UserPassword��$	��200��$��20��$��Center=�$
��Left=�$��5,0,0,0q��� $ 
Horizontal=�$��2��.+��� -    ��Name$ SaveSettingButton��$+��%Сохранить настройки��$��25��$	��150��$
��Left=��� -   $ ResetSettingButton��$)��#Сбросить настройки��$��2��$��25��$	��150��$
��Left=�$��10,0,0,0q�