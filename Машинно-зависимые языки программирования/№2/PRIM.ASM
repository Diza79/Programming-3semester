        org 100h
beg:      jmp start
messin	  db   0ah,0dh,'Введите значение N$'
messout	  db   0dh,0ah,'Результат вычисления выражения :$'  
N	  dw   ?
Y	  dw   ?
input_Buf db   06,00,5 dup(?)
answer    db   7 dup (?),'$'
include   bin2str.asm
include   str2bin.asm
fact	  proc
	  push cx
	  mov ax,1
cyc:	  imul cx
	  loop cyc
	  pop cx
	  ret
fact	  endp
start:    lea dx,messin	; в DX - адрес сообщения messin
	  mov ah,09h	; в AH - номер функции вывода строки 
	  int 21h       ; вызов прерывания DOS для вывода строки на экран
	  lea dx,input_buf
	  mov ah,0ah
	  int 21h
; преобразование введенной строки символов в число
	  mov bx,dx       ; перегрузить в bx адрес буфера
	  inc bx          ; увеличить адрес на единицу
	  call str2bin    ; обратиться к подпрограмме преобразования
; после этого в ax - число во внутреннем представлении
	  mov N,ax
	  mov cx,N
	  mov bx,0
cycl:	  call fact
	  add bx,ax
	  loop cycl
; на выходе из цикла в bx получаем результат
; преобразуем его в текстовую форму и выведем на экран
	  mov Y,bx
	  mov ax,bx
	  lea bx,answer
	  call bin2str
; собственно вывод на экран
	  lea dx,messout
	  mov ah,09h
	  int 21h
	  lea dx,answer+1
	  mov ah,09h
	  int 21h
	  int 20h          ; а затем завершаем работу
          end beg

