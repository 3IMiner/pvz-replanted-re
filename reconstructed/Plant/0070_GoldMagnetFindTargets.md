# System.Void GoldMagnetFindTargets()

- 类：`Plant`
- 汇编行数：261

## 反汇编

```asm

Disassembly:
	push rsi
	sub rsp,60h
	cmp byte ptr [184EEB67Ah],0
	mov rsi,rcx
	movaps [rsp+50h],xmm6
	movaps [rsp+40h],xmm7
	movaps [rsp+30h],xmm8
	movaps [rsp+20h],xmm9
	jne short 00000001806B1C9Bh
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	mov byte ptr [184EEB67Ah],1
	movss xmm6,dword ptr [183C33DB8h]
	movss xmm8,dword ptr [183C33DC4h]
	movss xmm7,dword ptr [183C33DBCh]
	movss xmm9,dword ptr [183C33F48h]
	mov [rsp+70h],rbx
	mov [rsp+78h],rdi
	nop word ptr [rax+rax]
	cmp dword ptr [rsi+70h],2Dh
	mov r9,[rsi+118h]
	je short 00000001806B1CF7h
	test r9,r9
	je near ptr 00000001806B1E3Ah
	cmp dword ptr [r9+18h],0
	jbe near ptr 00000001806B1E89h
	mov rbx,[r9+20h]
	jmp short 00000001806B1D69h
	xor eax,eax
	lea rdx,[r9+20h]
	xor r8d,r8d
	test r9,r9
	je near ptr 00000001806B1E3Ah
	nop dword ptr [rax]
	cmp eax,[r9+18h]
	jae near ptr 00000001806B1E89h
	mov rcx,[rdx]
	test rcx,rcx
	je near ptr 00000001806B1E3Ah
	cmp dword ptr [rcx+20h],0
	je short 00000001806B1D61h
	inc eax
	inc r8
	add rdx,8
	cmp r8,5
	jl short 00000001806B1D10h
	mov rdi,[rsp+78h]
	mov rbx,[rsp+70h]
	movaps xmm6,[rsp+50h]
	movaps xmm7,[rsp+40h]
	movaps xmm8,[rsp+30h]
	movaps xmm9,[rsp+20h]
	add rsp,60h
	pop rsi
	ret
	movsxd rcx,eax
	mov rbx,[r9+rcx*8+20h]
	test rbx,rbx
	je short 00000001806B1D3Bh
	xor edx,edx
	mov rcx,rsi
	call 00000001806AF170h
	mov rdi,rax
	test rax,rax
	je short 00000001806B1D3Bh
	movss xmm0,dword ptr [rax+70h]
	addss xmm0,xmm6
	movss dword ptr [rbx+10h],xmm0
	movss xmm1,dword ptr [rax+74h]
	addss xmm1,xmm6
	movss dword ptr [rbx+14h],xmm1
	mov rcx,[184C2AFC0h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B1DB1h
	call 00000001804FEEB0h
	xor r8d,r8d
	movaps xmm1,xmm8
	movaps xmm0,xmm7
	call 00000001806CBD40h
	movss dword ptr [rbx+18h],xmm0
	xor r8d,r8d
	movaps xmm0,xmm9
	xorps xmm1,xmm1
	call 00000001806CBD40h
	addss xmm0,xmm7
	movss dword ptr [rbx+1Ch],xmm0
	cmp dword ptr [rdi+0B0h],1
	je short 00000001806B1E24h
	cmp dword ptr [rdi+0B0h],2
	je short 00000001806B1E0Eh
	cmp dword ptr [rdi+0B0h],3
	jne short 00000001806B1E40h
	xor edx,edx
	mov dword ptr [rbx+20h],14h
	mov rcx,rdi
	call 00000001806972A0h
	jmp near ptr 00000001806B1CD0h
	xor edx,edx
	mov dword ptr [rbx+20h],13h
	mov rcx,rdi
	call 00000001806972A0h
	jmp near ptr 00000001806B1CD0h
	mov dword ptr [rbx+20h],12h
	xor edx,edx
	mov rcx,rdi
	call 00000001806972A0h
	jmp near ptr 00000001806B1CD0h
	call 00000001804FEE20h
	int 3
	lea rcx,[184C52578h]
	call 00000001804FEB90h
	mov rcx,rax
	call 00000001804FEDD0h
	lea rcx,[184C8ECA8h]
	mov rbx,rax
	call 00000001804FEB90h
	mov rdx,rax
	xor r8d,r8d
	mov rcx,rbx
	call 0000000182C223D0h
	lea rcx,[184C43DC0h]
	call 00000001804FEB90h
	mov rdx,rax
	mov rcx,rbx
	call 00000001804FEDE0h
	int 3
	call 00000001804FEE10h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rsi
	003 ShiftStack -96
	004 Compare [0x184EEB67A], 0
	005 Move rsi, rcx
	006 Move stack:0x50, xmm6
	007 Move stack:0x40, xmm7
	008 Move stack:0x30, xmm8
	009 Move stack:0x20, xmm9
	010 JumpIfNotEqual {14}
	011 LoadAddress rcx, [0x184C2AFC0]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 Move [0x184EEB67A], 1
	014 Move xmm6, [0x183C33DB8]
	015 Move xmm8, [0x183C33DC4]
	016 Move xmm7, [0x183C33DBC]
	017 Move xmm9, [0x183C33F48]
	018 Move stack:0x70, rbx
	019 Move stack:0x78, rdi
	020 Nop 
	021 Compare [rsi+112], 45
	022 Move r9, [rsi+280]
	023 JumpIfEqual {30}
	024 Compare r9, 0
	025 JumpIfEqual {110}
	026 Compare [r9+24], 0
	027 JumpIfLessOrEqual {129}
	028 Move rbx, [r9+32]
	029 Goto {60}
	030 Move rax, 0
	031 LoadAddress rdx, [r9+32]
	032 Move r8, 0
	033 Compare r9, 0
	034 JumpIfEqual {110}
	035 Nop 
	036 Compare rax, [r9+24]
	037 JumpIfGreaterOrEqual {129}
	038 Move rcx, [rdx]
	039 Compare rcx, 0
	040 JumpIfEqual {110}
	041 Compare [rcx+32], 0
	042 JumpIfEqual {58}
	043 Add rax, rax, 1
	044 Add r8, r8, 1
	045 Add rdx, rdx, 8
	046 Compare r8, 5
	047 JumpIfLess {36}
	048 Move rdi, stack:0x78
	049 Move rbx, stack:0x70
	050 Move xmm6, stack:0x50
	051 Move xmm7, stack:0x40
	052 Move xmm8, stack:0x30
	053 Move xmm9, stack:0x20
	054 ShiftStack 96
	055 Move rsi, stack:0x0
	056 ShiftStack 8
	057 Return 
	058 Move rcx, rax
	059 Move rbx, [r9+32+rcx*8]
	060 Compare rbx, 0
	061 JumpIfEqual {48}
	062 Move rdx, 0
	063 Move rcx, rsi
	064 Call Plant.FindGoldMagnetTarget, rcx, rdx
	065 Move rdi, rax
	066 Compare rax, 0
	067 JumpIfEqual {48}
	068 Move xmm0, [rax+112]
	069 Add xmm0, xmm0, xmm6
	070 Move [rbx+16], xmm0
	071 Move xmm1, [rax+116]
	072 Add xmm1, xmm1, xmm6
	073 Move [rbx+20], xmm1
	074 Move rcx, typeof(Reloaded.Gameplay.Common)
	075 Compare [rcx+228], 0
	076 JumpIfNotEqual {78}
	077 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	078 Move r8, 0
	079 Move xmm1, xmm8
	080 Move xmm0, xmm7
	081 Call Common.RandRangeFloat, xmm0, xmm1, r8
	082 Move [rbx+24], xmm0
	083 Move r8, 0
	084 Move xmm0, xmm9
	085 Move xmm1, 0
	086 Call Common.RandRangeFloat, xmm0, xmm1, r8
	087 Add xmm0, xmm0, xmm7
	088 Move [rbx+28], xmm0
	089 Compare [rdi+176], 1
	090 JumpIfEqual {105}
	091 Compare [rdi+176], 2
	092 JumpIfEqual {100}
	093 Compare [rdi+176], 3
	094 JumpIfNotEqual {112}
	095 Move rdx, 0
	096 Move [rbx+32], 20
	097 Move rcx, rdi
	098 Call Coin.Die, rcx, rdx
	099 Goto {21}
	100 Move rdx, 0
	101 Move [rbx+32], 19
	102 Move rcx, rdi
	103 Call Coin.Die, rcx, rdx
	104 Goto {21}
	105 Move [rbx+32], 18
	106 Move rdx, 0
	107 Move rcx, rdi
	108 Call Coin.Die, rcx, rdx
	109 Goto {21}
	110 Call 0x1804FEE20, rcx, rdx, r8, r9
	111 Interrupt 
	112 LoadAddress rcx, [0x184C52578]
	113 Call 0x1804FEB90, rcx, rdx, r8, r9
	114 Move rcx, rax
	115 Call "il2cpp_codegen_object_new", rcx, rdx, r8, r9
	116 LoadAddress rcx, [0x184C8ECA8]
	117 Move rbx, rax
	118 Call 0x1804FEB90, rcx, rdx, r8, r9
	119 Move rdx, rax
	120 Move r8, 0
	121 Move rcx, rbx
	122 Call Exception..ctor, rcx, rdx
	123 LoadAddress rcx, [0x184C43DC0]
	124 Call 0x1804FEB90, rcx, rdx, r8, r9
	125 Move rdx, rax
	126 Move rcx, rbx
	127 Call 0x1804FEDE0, rcx, rdx, r8, r9
	128 Interrupt 
	129 Call 0x1804FEE10, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
