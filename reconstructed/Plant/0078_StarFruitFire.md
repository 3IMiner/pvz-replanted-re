# System.Void StarFruitFire()

- 类：`Plant`
- 汇编行数：329

## 反汇编

```asm

Disassembly:
	push rsi
	sub rsp,0B0h
	cmp byte ptr [184EEB66Bh],0
	mov rsi,rcx
	jne short 00000001806B5E84h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C75168h]
	call 00000001804FEB70h
	mov byte ptr [184EEB66Bh],1
	mov rax,[rsi+10h]
	mov [rsp+0C0h],rbx
	mov [rsp+0C8h],rbp
	mov [rsp+0D0h],rdi
	movaps [rsp+0A0h],xmm6
	movaps [rsp+90h],xmm7
	movaps [rsp+80h],xmm8
	movaps [rsp+70h],xmm9
	movaps [rsp+60h],xmm10
	movaps [rsp+50h],xmm11
	movaps [rsp+40h],xmm12
	test rax,rax
	je near ptr 00000001806B6116h
	mov r8,[rax+58h]
	test r8,r8
	je near ptr 00000001806B6116h
	mov rdx,[184C75168h]
	mov ecx,6
	mov r9d,3
	call 0000000180002040h
	movss xmm12,dword ptr [183C33DC0h]
	xor ebp,ebp
	movss xmm11,dword ptr [183C33C60h]
	mov ebx,ebp
	movss xmm9,dword ptr [183C33FA0h]
	xorps xmm8,xmm8
	movss xmm10,dword ptr [183C34004h]
	nop word ptr [rax+rax]
	mov rcx,[rsi+18h]
	test rcx,rcx
	je near ptr 00000001806B6116h
	movss xmm2,dword ptr [rsi+24h]
	movss xmm1,dword ptr [rsi+20h]
	addss xmm2,xmm12
	mov r9d,[rsi+38h]
	addss xmm1,xmm12
	mov eax,[rsi+34h]
	dec r9d
	mov [rsp+30h],rbp
	mov dword ptr [rsp+28h],7
	mov [rsp+20h],eax
	call 0000000180655650h
	mov rdi,rax
	test rax,rax
	je near ptr 00000001806B6116h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rsi
	call 00000001806B12F0h
	mov [rdi+0C0h],eax
	mov dword ptr [rdi+0A4h],7
	mov rcx,[184C2AFC0h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B5FAEh
	call 00000001804FEEB0h
	xor edx,edx
	movaps xmm0,xmm11
	call 00000001806CB830h
	cmp [184EEB633h],bpl
	movaps xmm6,xmm0
	jne short 00000001806B5FD8h
	lea rcx,[184CAAE68h]
	call 00000001804FEB70h
	mov byte ptr [184EEB633h],1
	mov rcx,[184CAAE68h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B5FECh
	call 00000001804FEEB0h
	xorps xmm0,xmm0
	cvtss2sd xmm0,xmm6
	call 00000001805D9D50h
	xorps xmm6,xmm6
	xor edx,edx
	cvtsd2ss xmm6,xmm0
	movaps xmm0,xmm11
	mulss xmm6,xmm9
	call 00000001806CB830h
	cmp [184EEB632h],bpl
	movaps xmm7,xmm0
	jne short 00000001806B602Eh
	lea rcx,[184CAAE68h]
	call 00000001804FEB70h
	mov byte ptr [184EEB632h],1
	mov rcx,[184CAAE68h]
	cmp [rcx+0E4h],ebp
	jne short 00000001806B6042h
	call 00000001804FEEB0h
	xorps xmm0,xmm0
	cvtss2sd xmm0,xmm7
	call 00000001805DA2D0h
	xorps xmm1,xmm1
	mov ecx,ebx
	cvtsd2ss xmm1,xmm0
	mulss xmm1,xmm9
	test ebx,ebx
	je short 00000001806B608Eh
	sub ecx,1
	je short 00000001806B6084h
	sub ecx,1
	je short 00000001806B607Ah
	sub ecx,1
	je short 00000001806B6096h
	cmp ecx,1
	jne near ptr 00000001806B611Ch
	jmp short 00000001806B60ADh
	movaps xmm1,xmm10
	movaps xmm6,xmm8
	jmp short 00000001806B6096h
	movaps xmm1,xmm9
	movaps xmm6,xmm8
	jmp short 00000001806B6096h
	movaps xmm1,xmm8
	movaps xmm6,xmm10
	movss dword ptr [rdi+88h],xmm6
	inc ebx
	movss dword ptr [rdi+8Ch],xmm1
	jmp near ptr 00000001806B5F30h
	movss dword ptr [rdi+88h],xmm6
	xorps xmm1,[183C33CA0h]
	movss dword ptr [rdi+8Ch],xmm1
	movaps xmm12,[rsp+40h]
	movaps xmm11,[rsp+50h]
	movaps xmm10,[rsp+60h]
	movaps xmm9,[rsp+70h]
	movaps xmm8,[rsp+80h]
	movaps xmm7,[rsp+90h]
	movaps xmm6,[rsp+0A0h]
	mov rdi,[rsp+0D0h]
	mov rbp,[rsp+0C8h]
	mov rbx,[rsp+0C0h]
	add rsp,0B0h
	pop rsi
	ret
	call 00000001804FEE20h
	int 3
	lea rcx,[184C52578h]
	call 00000001804FEB90h
	mov rcx,rax
	call 00000001804FEDD0h
	lea rcx,[184C8CD70h]
	mov rbx,rax
	call 00000001804FEB90h
	mov rdx,rax
	xor r8d,r8d
	mov rcx,rbx
	call 0000000182C223D0h
	lea rcx,[184C43E98h]
	call 00000001804FEB90h
	mov rdx,rax
	mov rcx,rbx
	call 00000001804FEDE0h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rsi
	003 ShiftStack -176
	004 Compare [0x184EEB66B], 0
	005 Move rsi, rcx
	006 JumpIfNotEqual {12}
	007 LoadAddress rcx, [0x184C2AFC0]
	008 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	009 LoadAddress rcx, [0x184C75168]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 Move [0x184EEB66B], 1
	012 Move rax, [rsi+16]
	013 Move stack:0xC0, rbx
	014 Move stack:0xC8, rbp
	015 Move stack:0xD0, rdi
	016 Move stack:0xA0, xmm6
	017 Move stack:0x90, xmm7
	018 Move stack:0x80, xmm8
	019 Move stack:0x70, xmm9
	020 Move stack:0x60, xmm10
	021 Move stack:0x50, xmm11
	022 Move stack:0x40, xmm12
	023 Compare rax, 0
	024 JumpIfEqual {146}
	025 Move r8, [rax+88]
	026 Compare r8, 0
	027 JumpIfEqual {146}
	028 Move rdx, typeof(Reloaded.Services.IAudioService)
	029 Move rcx, 6
	030 Move r9, 3
	031 Call 0x180002040, rcx, rdx, r8, r9
	032 Move xmm12, [0x183C33DC0]
	033 Move rbp, 0
	034 Move xmm11, [0x183C33C60]
	035 Move rbx, rbp
	036 Move xmm9, [0x183C33FA0]
	037 Move xmm8, 0
	038 Move xmm10, [0x183C34004]
	039 Nop 
	040 Move rcx, [rsi+24]
	041 Compare rcx, 0
	042 JumpIfEqual {146}
	043 Move xmm2, [rsi+36]
	044 Move xmm1, [rsi+32]
	045 Add xmm2, xmm2, xmm12
	046 Move r9, [rsi+56]
	047 Add xmm1, xmm1, xmm12
	048 Move rax, [rsi+52]
	049 Subtract r9, r9, 1
	050 Move stack:0x30, rbp
	051 Move stack:0x28, 7
	052 Move stack:0x20, rax
	053 Call Board.AddProjectile, rcx, xmm1, r8, r9, stack:0x0, stack:0x8
	054 Move rdi, rax
	055 Compare rax, 0
	056 JumpIfEqual {146}
	057 Move r8, 0
	058 Move rdx, 0
	059 Move rcx, rsi
	060 Call Plant.GetDamageRangeFlags, rcx, rdx
	061 Move [rdi+192], rax
	062 Move [rdi+164], 7
	063 Move rcx, typeof(Reloaded.Gameplay.Common)
	064 Compare [rcx+228], rbp
	065 JumpIfNotEqual {67}
	066 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	067 Move rdx, 0
	068 Move xmm0, xmm11
	069 Call 0x1806CB830, xmm0, rdx
	070 Compare [0x184EEB633], rbp
	071 Move xmm6, xmm0
	072 JumpIfNotEqual {76}
	073 LoadAddress rcx, [0x184CAAE68]
	074 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	075 Move [0x184EEB633], 1
	076 Move rcx, typeof(System.Math)
	077 Compare [rcx+228], rbp
	078 JumpIfNotEqual {80}
	079 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	080 Move xmm0, 0
	081 NotImplemented "cvtss2sd xmm0,xmm6"
	082 Call 0x1805D9D50, rcx, rdx, r8, r9
	083 Move xmm6, 0
	084 Move rdx, 0
	085 NotImplemented "cvtsd2ss xmm6,xmm0"
	086 Move xmm0, xmm11
	087 Multiply xmm6, xmm6, xmm9
	088 Call 0x1806CB830, xmm0, rdx
	089 Compare [0x184EEB632], rbp
	090 Move xmm7, xmm0
	091 JumpIfNotEqual {95}
	092 LoadAddress rcx, [0x184CAAE68]
	093 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	094 Move [0x184EEB632], 1
	095 Move rcx, typeof(System.Math)
	096 Compare [rcx+228], rbp
	097 JumpIfNotEqual {99}
	098 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	099 Move xmm0, 0
	100 NotImplemented "cvtss2sd xmm0,xmm7"
	101 Call 0x1805DA2D0, rcx, rdx, r8, r9
	102 Move xmm1, 0
	103 Move rcx, rbx
	104 NotImplemented "cvtsd2ss xmm1,xmm0"
	105 Multiply xmm1, xmm1, xmm9
	106 Compare rbx, 0
	107 JumpIfEqual {123}
	108 Subtract rcx, rcx, 1
	109 JumpIfEqual {120}
	110 Subtract rcx, rcx, 1
	111 JumpIfEqual {117}
	112 Subtract rcx, rcx, 1
	113 JumpIfEqual {125}
	114 Compare rcx, 1
	115 JumpIfNotEqual {148}
	116 Goto {129}
	117 Move xmm1, xmm10
	118 Move xmm6, xmm8
	119 Goto {125}
	120 Move xmm1, xmm9
	121 Move xmm6, xmm8
	122 Goto {125}
	123 Move xmm1, xmm8
	124 Move xmm6, xmm10
	125 Move [rdi+136], xmm6
	126 Add rbx, rbx, 1
	127 Move [rdi+140], xmm1
	128 Goto {40}
	129 Move [rdi+136], xmm6
	130 Xor xmm1, xmm1, [0x183C33CA0]
	131 Move [rdi+140], xmm1
	132 Move xmm12, stack:0x40
	133 Move xmm11, stack:0x50
	134 Move xmm10, stack:0x60
	135 Move xmm9, stack:0x70
	136 Move xmm8, stack:0x80
	137 Move xmm7, stack:0x90
	138 Move xmm6, stack:0xA0
	139 Move rdi, stack:0xD0
	140 Move rbp, stack:0xC8
	141 Move rbx, stack:0xC0
	142 ShiftStack 176
	143 Move rsi, stack:0x0
	144 ShiftStack 8
	145 Return 
	146 Call 0x1804FEE20, rcx, rdx, r8, r9
	147 Interrupt 
	148 LoadAddress rcx, [0x184C52578]
	149 Call 0x1804FEB90, rcx, rdx, r8, r9
	150 Move rcx, rax
	151 Call "il2cpp_codegen_object_new", rcx, rdx, r8, r9
	152 LoadAddress rcx, [0x184C8CD70]
	153 Move rbx, rax
	154 Call 0x1804FEB90, rcx, rdx, r8, r9
	155 Move rdx, rax
	156 Move r8, 0
	157 Move rcx, rbx
	158 Call Exception..ctor, rcx, rdx
	159 LoadAddress rcx, [0x184C43E98]
	160 Call 0x1804FEB90, rcx, rdx, r8, r9
	161 Move rdx, rax
	162 Move rcx, rbx
	163 Call 0x1804FEDE0, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
