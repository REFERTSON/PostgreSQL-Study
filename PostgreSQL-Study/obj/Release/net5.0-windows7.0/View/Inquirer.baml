   M S B A M L   `   `   `  ���� K  GPostgreSQL-Study, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:PostgreSQL_Study.ViewPostgreSQL_Study.View  $    PostgreSQL_Study.View.Inquirer   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     5local#clr-namespace:PostgreSQL_Study.View       N� Title$  Inquirer��.��� $��15, 15, 15, 10q� � RowDefinitions �� $��40 ��� $
��0.6* ��� .+�� $��0�� � ColumnDefinitions �� $
��Auto ��� $��* �.+��� $��20(�$��0��$	��400������  �� Orientation$ 
Horizontal=�.+��� $��Запросник   |   ���� -    ��Name$ FileName���� $ 
Horizontal=�$��1��$��Right=�.+��� -    ��Name$ RunQueryButton��$��25��$	��110��   InquiererButtonTheme#��[  ���� Выполнить�� -   $ ClearQueryButton��$��25��$	��100��$��10,0,0,0q�#��[  ���� Очистить�� -   $ ExportResultButton��$��25��$	��100��$��	10,0,15,0q�#��[  ���� Экспорт�� -    ��Name$ QueryTextBox��$��1��$
��0, 5q�" �� VerticalScrollBarVisibility$
 Auto=�$ �� HorizontalScrollBarVisibility$
 Auto=�	 �� AcceptsReturn$
	 True���� -   
 ��Name$
 	TabResult��$��2��.@��� ���� $ 
Horizontal=�.+��� Результаты��&   System.Windows.Controls.DataGrid  -     Name$ InquirerItemTable��   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ *    EnableRowVirtualization$ false��!   EnableColumnVirtualization$ false��$��2  badr)�   CanUserResizeColumns$ False��   CanUserResizeRows$ False��   CanUserAddRows$ False��   CanUserReorderColumns$ False��   CanUserSortColumns$ False��$��3q��� $��22������ $ 
Horizontal=�.+��� Сообщения���� -   $ MessageResult��$��10q�$
��Wrap=�