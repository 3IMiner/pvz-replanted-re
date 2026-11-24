# System.Boolean DrawMagnetItemsOnTop()

- 类：`Plant`
- 汇编行数：153

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rsi
	push rdi
	sub rsp,30h
	cmp dword ptr [rcx+70h],2Dh
	mov rsi,rcx
	movaps [rsp+20h],xmm6
	je near ptr 00000001806AE49Ch
	cmp dword ptr [rcx+70h],1Fh
	jne near ptr 00000001806AE4D3h
	movss xmm6,dword ptr [183C33DBCh]
	xor ebx,ebx
	mov edi,20h
	nop word ptr [rax+rax]
	mov rax,[rsi+118h]
	test rax,rax
	je near ptr 00000001806AE4EEh
	cmp ebx,[rax+18h]
	jae near ptr 00000001806AE4F4h
	mov rcx,[rdi+rax]
	test rcx,rcx
	je near ptr 00000001806AE4EEh
	cmp dword ptr [rcx+20h],0
	je short 00000001806AE48Eh
	movss xmm0,dword ptr [rcx+18h]
	xor edx,edx
	movss xmm1,dword ptr [rcx+1Ch]
	addss xmm0,dword ptr [rsi+20h]
	addss xmm1,dword ptr [rsi+24h]
	subss xmm0,dword ptr [rcx+10h]
	subss xmm1,dword ptr [rcx+14h]
	unpcklps xmm0,xmm1
	movq rcx,xmm0
	call 00000001806AB080h
	comiss xmm0,xmm6
	ja short 00000001806AE4EAh
	inc ebx
	add rdi,8
	cmp rdi,48h
	jl short 00000001806AE430h
	jmp short 00000001806AE4D3h
	mov r8,[rcx+118h]
	xor ebx,ebx
	lea rcx,[r8+20h]
	mov eax,ebx
	test r8,r8
	je short 00000001806AE4EEh
	cmp ebx,[r8+18h]
	jae short 00000001806AE4F4h
	mov rdx,[rcx]
	test rdx,rdx
	je short 00000001806AE4EEh
	cmp dword ptr [rdx+20h],0
	jne short 00000001806AE4EAh
	inc ebx
	inc rax
	add rcx,8
	cmp rax,5
	jl short 00000001806AE4B0h
	xor al,al
	mov rbx,[rsp+40h]
	mov rsi,[rsp+48h]
	movaps xmm6,[rsp+20h]
	add rsp,30h
	pop rdi
	ret
	mov al,1
	jmp short 00000001806AE4D5h
	call 00000001804FEE20h
	int 3
	call 00000001804FEE10h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -48
	006 Compare [rcx+112], 45
	007 Move rsi, rcx
	008 Move stack:0x20, xmm6
	009 JumpIfEqual {47}
	010 Compare [rcx+112], 31
	011 JumpIfNotEqual {65}
	012 Move xmm6, [0x183C33DBC]
	013 Move rbx, 0
	014 Move rdi, 32
	015 Nop 
	016 Move rax, [rsi+280]
	017 Compare rax, 0
	018 JumpIfEqual {75}
	019 Compare rbx, [rax+24]
	020 JumpIfGreaterOrEqual {77}
	021 Move rcx, [rdi+rax]
	022 Compare rcx, 0
	023 JumpIfEqual {75}
	024 Compare [rcx+32], 0
	025 JumpIfEqual {42}
	026 Move xmm0, [rcx+24]
	027 Move rdx, 0
	028 Move xmm1, [rcx+28]
	029 Add xmm0, xmm0, [rsi+32]
	030 Add xmm1, xmm1, [rsi+36]
	031 Subtract xmm0, xmm0, [rcx+16]
	032 Subtract xmm1, xmm1, [rcx+20]
	033 Move XMM_TEMP.S[0], xmm0.S[0]
	034 Move XMM_TEMP.S[1], xmm1.S[0]
	035 Move XMM_TEMP.S[2], xmm0.S[1]
	036 Move XMM_TEMP.S[3], xmm1.S[1]
	037 Move xmm0, XMM_TEMP
	038 Move rcx, xmm0
	039 Call 0x1806AB080, rcx, rdx, r8, r9
	040 Compare xmm0, xmm6
	041 JumpIfGreater {73}
	042 Add rbx, rbx, 1
	043 Add rdi, rdi, 8
	044 Compare rdi, 72
	045 JumpIfLess {16}
	046 Goto {65}
	047 Move r8, [rcx+280]
	048 Move rbx, 0
	049 LoadAddress rcx, [r8+32]
	050 Move rax, rbx
	051 Compare r8, 0
	052 JumpIfEqual {75}
	053 Compare rbx, [r8+24]
	054 JumpIfGreaterOrEqual {77}
	055 Move rdx, [rcx]
	056 Compare rdx, 0
	057 JumpIfEqual {75}
	058 Compare [rdx+32], 0
	059 JumpIfNotEqual {73}
	060 Add rbx, rbx, 1
	061 Add rax, rax, 1
	062 Add rcx, rcx, 8
	063 Compare rax, 5
	064 JumpIfLess {53}
	065 Move rax, 0
	066 Move rbx, stack:0x40
	067 Move rsi, stack:0x48
	068 Move xmm6, stack:0x20
	069 ShiftStack 48
	070 Move rdi, stack:0x0
	071 ShiftStack 8
	072 Return rax
	073 Move rax, 1
	074 Goto {66}
	075 Call 0x1804FEE20, rcx, rdx, r8, r9
	076 Interrupt 
	077 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
