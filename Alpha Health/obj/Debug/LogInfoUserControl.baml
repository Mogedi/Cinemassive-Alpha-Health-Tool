   M S B A M L   `   `   `  ����G  CAlpha Health, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Alpha_HealthAlpha_Health  5      %    Alpha_Health.LogInfoUserControl   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Alpha_Health     5      
�������$	��400��5	      $
��1020��6   $��0,0,0,10q�6(   .��5
      � .+�5   
   �� -   5          ��Name$  title��5      $
��Left=�6#   $��	20,17,0,0q�6>   $
��Wrap=�6Q   $��	TextBlock��6e   $	��Top=�6v    J� RenderTransformOrigin$ 0,-0.627&�6�   $��	Underline{�6�   $��Times New Roman)�6�   $��16(�6�   $
��Bold"�6�   $��Italic$�6  �� 5   
   -   5        $
  date��5      $
��Left=�6"   $��	17,54,0,0q�6=   $
��Wrap=�6P   $��Date:��6d   $	��Top=�6q   $��Times New Roman)�6�   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $  	dateEntry��5      $
��Left=�6'   $��	55,54,0,0q�6B   $
��Wrap=�6U   $��	TextBlock��6i   $��Times New Roman)�6z   $	��Top=�6�   $��14(�6�   �� 5   
   -   5        $
  time��5      $
��Left=�6"   $��
146,54,0,0q�6=   $
��Wrap=�6Q   $��Time:��6e   $��Times New Roman)�6r   $	��Top=�6�   $��14(�6�   $ 0.304,0.373&�6�   $
��Bold"�6�   �� 5   
   -   5        $  	timeEntry��5      $
��Left=�6'   $��
187,54,0,0q�6B   $
��Wrap=�6V   $��	TextBlock��6j   $��Times New Roman)�6{   $	��Top=�6�   $��14(�6�   �� 5   
   -   5        $  
exceptions��5      $
��Left=�6(   $��
264,54,0,0q�6C   $
��Wrap=�6W   $��# of Exceptions:��6k   $��Times New Roman)�6�   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $  exceptionEntry��5      $
��Left=�6,   $��
365,54,0,0q�6G   $
��Wrap=�6[   $��	TextBlock��6o   $��Times New Roman)�6�   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   �� 5   
   -   5        $
  file��5      $
��Left=�6"   $��
441,54,0,0q�6=   $
��Wrap=�6Q   $��File Location:��6e   $��Times New Roman)�6{   $	��Top=�6�   $��14(�6�   $
��Bold"�6�   �� 5   
   -	   5        $  fileLocation��5      $
��Left=�6*   $��
530,54,0,0q�6E   $
��Wrap=�6Y   $��	TextBlock��6m   $��Times New Roman)�6~   $	��Top=�6�   $��14(�6�   �� 5   
   $��Stretch=�6   $	��110��65   $��40,115,40,0q�6B   $	��Top=�6W   .��5      �� -
   5         ��Name$ exceptionStackPanel��5      5      5      �� 5   
   -   5         ��Name$ exceptionText��5      $��Stretch=�6)   $	��155��6G   $��40,230,40,0q�6T    �� TextWrapping$ NoWrap=�6i   $�� ��6   $	��Top=�6�   $
��Auto=�6�   $
��Auto=�6�   �� 5   
   -   5         ��Name$ exceptionType��5      $��Exception Type��6'   $
��Left=�6@   $��	50,84,0,0q�6[   $	��Top=�6n   $	��110��6�   $
��Bold"�6�   �� 5   
   -   5        $ exceptionCount��5      $��# of Exception��6(   $��Center=�6A   $��
-20,84,0,0q�6^   $	��Top=�6r   $
��Bold"�6�   �� 5   
   -   5        $ exceptionShow��5      $��Show Exception��6'   $��Right=�6@   $��	0,84,87,0q�6\   $	��Top=�6o   $
��Bold"�6�   5      5      