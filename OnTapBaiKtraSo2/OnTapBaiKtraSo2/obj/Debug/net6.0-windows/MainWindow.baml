   M S B A M L   `   `   `  ����J  FOnTapBaiKtraSo2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:OnTapBaiKtraSo2OnTapBaiKtraSo2  5   	        OnTapBaiKtraSo2.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:OnTapBaiKtraSo2     5   	   -   5          � Title$&   Cập nhật bảng sản phẩm��5   	   $	��584��6(   $	��800��65   .��5	      � $	��565��6   $	��Top=�6    � ColumnDefinitions 5
   
   �� 5      $
��377* �6   �� 5      $	��23* �6    � RowDefinitions 5   
   �� 5      $
��314* �6   �� 5      $	��22* �6   �� 5      $
��229* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ dvgData��5      $��113,247,56,113q�6$   $��3��6<      AutoGenerateColumns$ False��5         CanUserAddRows$ False��5         AlternatingRowBackground
 �����   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã SP��6%   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 64   �� *MaSp+6O     5      $ Tên SP��6%   	 65   �� *TenSp+6Q     5      $ Mã loại Sp��6%   	 69   �� *MaLoai+6V     5      $ Số lượng��6%   	 67   �� *	SoLuong+6U     5      $ 
Đơn giá��6%   	 66   �� *DonGia+6S     5      $ Thành tiền��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6W   	 69   �� *	ThanhTien+6c   5      �� 5    
   $��Mã sản phẩm : ��6   $
��Left=�6)   $��
148,23,0,0q�6D   $	��Top=�6X   $	��104��6p   �� 5!   
   $��Tên sản phẩm :��6   $
��Left=�6)   $��
148,63,0,0q�6D   $	��Top=�6X   $	��104��6p   �� 5"   
   $��Loại sản phẩm : ��6   $
��Left=�6+   $��148,106,0,0q�6F   $	��Top=�6[   $	��104��6s   �� 5#   
   $��Đơn giá : ��6   $
��Left=�6%   $��148,148,0,0q�6@   $	��Top=�6U   $	��104��6m   �� 5$   
   $��Số lượng : ��6   $
��Left=�6&   $��148,199,0,0q�6A   $	��Top=�6V   $	��104��6n   �� 5%   
   -   5        $��txtMa��5%   U   $
��Left=�6   $��
307,23,0,0q�6-    �� TextWrapping$
 Wrap=�6A   $	��Top=�6b   $	��235��6z   $��26��6�   �� 5&   
   -   5        $��txtTen��5&   U   $
��Left=�6   $��
307,63,0,0q�6-   $
 Wrap=�6A   $	��Top=�6c   $	��235��6{   $��26��6�   �� 5'   
   -   5        $��txtDg��5'   V   $
��Left=�6   $��307,148,0,0q�6-   $
 Wrap=�6B   $	��Top=�6c   $	��235��6{   $��26��6�   �� 5(   
   -   5        $��txtSl��5(   V   $
��Left=�6   $��307,199,0,0q�6-   $
 Wrap=�6B   $	��Top=�6c   $	��235��6{   $��26��6�   �� 5)   
   -   5        $��cbLoai��5)   g   $
��Left=�6   $��307,110,0,0q�6.   $	��Top=�6C   $	��120��6[   6g   �� 5*   
   -   5        $��Thêm��5*      $
��Left=�67   $��166,171,0,0q�6R   $	��Top=�6g   $��68��6   $��2��6�   �� 5+   
   -	   5        $��Sửa��5+      $
��Left=�66   $��280,171,0,0q�6Q   $	��Top=�6f   $��70��6~   $��2��6�   �� 5,   
   -
   5        $
��Xóa��5,      $
��Left=�66   $��400,171,0,0q�6Q   $	��Top=�6f   $��70��6~   $��2��6�   �� 5-   
   -   5        $
��Tìm��5-      $
��Left=�67   $��507,171,0,0q�6R   $	��Top=�6g   $��70��6   $��2��6�   �� 5.   
   -   5        $��Thống kê��5.      $
��Left=�6:   $��605,171,0,0q�6U   $	��Top=�6j   $��70��6�   $��2��6�   50      51      