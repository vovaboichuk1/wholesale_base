   M S B A M L   `   `   `  ????F  BUserAppBeta, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:UserAppBetaUserAppBeta  5   	       UserAppBeta.Window1   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:UserAppBeta     5   	     ? Title$  Window1??5   	   $	??450??6   $	??800??6&   .??5	      ? ???	#FF673AB7.+?5
   
   ?? $	??400??6   $??15q?6    
???????$??Center=?6C    ?? Padding$ 30q?6^   $	??550??6k    ?? CornerRadius$ 20??6z    J? Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q?6#      Color$ 	LightCyan??63      ShadowDepth$ 0Q?6E   6W   ._?5      ?? .+?5      ?? $??Реєстрація??6   $??30(?6.   $
??Bold"?6<   $??0 0 0 20q?6N   6c   ?? 5      -   5         ??Name$ exampleText??5      $??15(?61   $??Medium"?6?   $??0 0 0 20q?6S   6h   ? 5      $??0 0 0 20q?6   .+?5      ?? -   5         ??Name$ Register_Program??5      $
??Left=?67   $??Реєстрація??6R   
???????$??0q?6   $??	430,0,0,0q?6?   $??20??6?   $??Bottom=?6?   6?   ?? 5      -   5        $
??Left=?5      $??Увійти??68   ???	#FF673AB7
???????6t   5      ?? 5      $??Введіть Ім'я??6   ?? 5      -   5        	 ??Name$	 TextBoxNames??5      ?? 5      $0??*Введіть Номер телефону??6   ?? 5      -   5        $	 TextBoxNumber_Phone??5      67   ?? 5      $!??Введіть Пароль??6   G? 5      -   5        
 G?Name$
 TextBoxPassword??5      ?? 5      $)??#Підтвердіть пароль??6   G? 5      -   5        $
 TextBoxPssword2??5      5      5      5      5       