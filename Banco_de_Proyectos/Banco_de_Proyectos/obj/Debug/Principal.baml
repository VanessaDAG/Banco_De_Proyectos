   M S B A M L   `   `   `  ����  Banco_de_Proyectos#    Banco_de_Proyectos.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F   -   5          �Name$  	Principal��5   �    � Title$ 
MainWindow��5   	   $��733.505��6   $��737.371��6-    � WindowStyle$
 None=�6=    � AllowsTransparency .  � 	Resources 5         btnclose �� 
TargetType �� Property �� Value �� 
TargetType	 ��Name
 �� Triggers P� Property P� Value �� 
TargetName  	cerrarbtn ��Name J� Opacity��%�  &	        &	 N    �� 5      " ��6   .�5      ��  � �� 5	      �� 5
      " ��6   .R�5      � .+�5   	   �� $	 image��6   $��close_window-128.png��6   $
��Fill=�6<   $��-290,-331,372,413q�6K   5   	   
 5      P� 5   	    �@��IsCancel .  6%   P� 5   	    �@J�	IsFocused . 6&   P� 5   	    �@��IsDefaulted . 6(   P� 5   	    �@J�IsMouseOver . . �5   
   �� $ image��6(    �@J�OpacityMask �	#FF6E6E6E6;   5   
   P� 5   	    � �� . 6&   P� 5   	    � {� .  6&   5      5      5      �� 5      " ��6   .�5      ��  � �� 5      �� 5      " ��6   .R�5       � .+�5!   	   �� $ 	rectangle��6   ���	#B2878787���	#80807C7C$ 0Q�6J   5"   	   
 5#      P� 5$   	    �@J�	IsFocused . 6&   P� 5%   	    �@��IsDefaulted . 6(   P� 5&   	    �@J�IsMouseOver . . �5'   
   �� $ 	rectangle��6$    �@J�Opacity$ 0.995Q�6;   �� 5(   
   $ 	rectangle��6!    � �� �	#C087878768   5)   
   P� 5*   	    � �� . 6&   P� 5+   	    � {� .  6&   5-      5/      50      51       � Triggers 52      :� 53   
    :� RoutedEvent$ DragDrop.DragOver��6    :� 
SourceName$ 	btncerrar��67   ��55      �� 56   
    �� EndPoint$ 	262.5,350&�6    � MappingMode$ Absolute=�63    �� 
StartPoint$ 262.5,0&�6J    �� RelativeTransform 57      V� 58      .~�59      ��  �� CenterY$	 0.5Q�6%    �� CenterX$	 0.8Q�63   �� 5:       �� CenterY$	 0.5Q�6$    �� CenterX$	 0.8Q�62    �� AngleY$ 1Q�6@    �� AngleX$ 56Q�6K   �� 5;       �� Angle$ 129.094Q�6&    �� CenterY$	 0.5Q�66    �� CenterX$	 0.8Q�6D   T� 5<      5=      .��5?      �   � Color$  	#FF00001F��6   ! � Offset$
! 0.19Q�6-   � 5@      $  	#FF006666��6   $! 1Q�6-   5A      .��5C      � " J� IsManipulationEnabled" . # � ColumnDefinitions# 5D   
   �� 5E      .+�5G   
   �� -   5        $ ��Name$$ 	btncerrar��5G      $��Cerrar��6$   $
��Left=�65   $��47��6P   $��
649,97,0,0q�6\   $	��Top=�6p   $��65.072��6�   
�������$��18.667(�6�   
���������5H      �� 5I      5K      �� 5L   
   $��Proyectos Actuales��6   $
��Left=�6-   $��87��6H   $��	10,10,0,0q�6T   $	��Top=�6g   $	��639��6   $��50(�6�   $��Lucida Calligraphy)�6�   $
��Bold"�6�   &   System.Windows.Controls.DataGrid  5M   
   -   5        %  Name$% 
gvUsuarios��5M      $
��Left=�6'   $	��621��6B   $��
10,102,0,0q�6O   $	��Top=�6c   $	��610��6{   &   CanUserResizeRows& .  ���	#FFF0F0F0'   Columns' 5N      4  .System.Windows.Controls.DataGridCheckBoxColumn  5O      ,  &System.Windows.Controls.DataGridColumn(   Header$( 	Matricula��6_   )   HeaderStringFormat$) 
Matrícula��6r   1  +System.Windows.Controls.DataGridBoundColumn*   Binding* 6)   Z� +   ClipboardContentBinding+ 6<   Z� 6r   0  *System.Windows.Controls.DataGridTextColumn  5P      $( Folio��6[   $) Folio��6j   ,   
Foreground, �	#FFB9FF00* 6%   Z� + 68   Z� 6�   5R      �� 5S   
   $��Acceder��6   $
��Left=�6"   $��42��6=   $��637,265,0,0q�6I   $	��Top=�6^   $��82��6v   $��18(�6�   $��Book Antiqua)�6�   $
��Bold"�6�   �� 5T   
   -   5        - ��Name$- 	btnalumno��5T      $��Registrar 
Alumno��6#   $
��Left=�6H   $��61��6c   $��637,374,0,0q�6o   $	��Top=�6�   $��93��6�   $��18(�6�   $��Book Antiqua)�6�   $
��Bold"�6�   �� 5U   
   -   5        $- btnproyecto��5U      $��Registrar 
Proyecto��6%   $
��Left=�6L   $��65��6g   $��634,532,0,0q�6s   $	��Top=�6�   $��93��6�   $��18(�6�   $��Book Antiqua)�6�   $
��Bold"�6�   ���	#00000000
�������6�   �� 5V   
   $ ��710.668,4.002,5.37,708.503q�6   $��close_window-48.png��64   $
��Fill=�6Q   �� 5W   
   $"��684.335,4.002,31.703,708.503q�6   $��minimize_window-48.png��66   $
��Fill=�6V   �� 5X   
   -   5        $$ btnclose��5X      $��Button��6#   $
��Left=�64   $
��21.7��6O   $��710.668,4.002,0,0q�6]   #���  6x   $	��Top=�6�   $
��21.4��6�   $��0,1,1,1q�6�   �� 5Y   
   -   5        $$ btnmini��5Y      $��Button��6"   $
��Left=�63   $
��21.7��6N   $��684.335,4.002,0,0q�6\   #���  6w   $	��Top=�6�   $
��21.4��6�   6�   5[      5\      