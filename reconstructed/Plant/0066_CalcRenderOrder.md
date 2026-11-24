# System.Int32 CalcRenderOrder()

- 类：`Plant`
- 汇编行数：243

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	mov [rsp+20h],rdi
	push r14
	sub rsp,20h
	cmp byte ptr [184EEB65Dh],0
	mov rbx,rcx
	jne short 00000001806AC2D9h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB65Dh],1
	mov edi,[rbx+70h]
	mov esi,1
	mov r14d,49BB0h
	cmp edi,30h
	jne short 00000001806AC2FBh
	cmp dword ptr [rbx+12Ch],0FFFFFFFFh
	je short 00000001806AC2FBh
	mov edi,[rbx+12Ch]
	mov rcx,[184C2D478h]
	mov rbp,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AC314h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rbp
	call 0000000183832900h
	test al,al
	je short 00000001806AC348h
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AC461h
	xor edx,edx
	call 00000001807DFA20h
	test al,al
	je short 00000001806AC348h
	mov r14d,4A768h
	jmp near ptr 00000001806AC41Eh
	cmp edi,1Eh
	je near ptr 00000001806AC41Eh
	cmp edi,23h
	je near ptr 00000001806AC419h
	cmp edi,21h
	je near ptr 00000001806AC41Eh
	cmp edi,10h
	jne short 00000001806AC3ACh
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AC381h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je near ptr 00000001806AC41Eh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je near ptr 00000001806AC461h
	xor edx,edx
	call 00000001807E3010h
	jmp short 00000001806AC41Eh
	cmp edi,3
	je short 00000001806AC41Eh
	cmp edi,0Bh
	jne short 00000001806AC41Eh
	mov rcx,[184C2D478h]
	mov rdi,[rbx+10h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806AC3CFh
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806AC41Eh
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806AC461h
	xor edx,edx
	call 00000001807DF9F0h
	test al,al
	je short 00000001806AC41Eh
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806AC461h
	mov r8d,[rbx+34h]
	xor r9d,r9d
	mov edx,[rbx+74h]
	call 000000018065F400h
	test rax,rax
	je short 00000001806AC41Eh
	mov eax,[rax+38h]
	add eax,0Bh
	jmp short 00000001806AC446h
	mov esi,3
	movd xmm1,dword ptr [rbx+34h]
	lea eax,[rsi+0A0h]
	lea edx,[rax+rax*4]
	xor r9d,r9d
	movd xmm2,edx
	mov ecx,r14d
	cvtdq2ps xmm2,xmm2
	cvtdq2ps xmm1,xmm1
	subss xmm2,dword ptr [rbx+20h]
	call 0000000180665050h
	mov rbx,[rsp+30h]
	mov rbp,[rsp+38h]
	mov rsi,[rsp+40h]
	mov rdi,[rsp+48h]
	add rsp,20h
	pop r14
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rsi
	004 Move stack:0x20, rdi
	005 ShiftStack -8
	006 Move stack:0x0, r14
	007 ShiftStack -32
	008 Compare [0x184EEB65D], 0
	009 Move rbx, rcx
	010 JumpIfNotEqual {14}
	011 LoadAddress rcx, [0x184C2D478]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 Move [0x184EEB65D], 1
	014 Move rdi, [rbx+112]
	015 Move rsi, 1
	016 Move r14, 0x49BB0
	017 Compare rdi, 48
	018 JumpIfNotEqual {22}
	019 Compare [rbx+300], 18446744073709551615
	020 JumpIfEqual {22}
	021 Move rdi, [rbx+300]
	022 Move rcx, typeof(UnityEngine.Object)
	023 Move rbp, [rbx+16]
	024 Compare [rcx+228], 0
	025 JumpIfNotEqual {27}
	026 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	027 Move r8, 0
	028 Move rdx, 0
	029 Move rcx, rbp
	030 Call Object.op_Inequality, rcx, rdx, r8
	031 Compare rax, 0
	032 JumpIfEqual {42}
	033 Move rcx, [rbx+16]
	034 Compare rcx, 0
	035 JumpIfEqual {120}
	036 Move rdx, 0
	037 Call GameplayActivity.IsWallnutBowlingLevel, rcx, rdx
	038 Compare rax, 0
	039 JumpIfEqual {42}
	040 Move r14, 0x4A768
	041 Goto {102}
	042 Compare rdi, 30
	043 JumpIfEqual {102}
	044 Compare rdi, 35
	045 JumpIfEqual {101}
	046 Compare rdi, 33
	047 JumpIfEqual {102}
	048 Compare rdi, 16
	049 JumpIfNotEqual {67}
	050 Move rcx, typeof(UnityEngine.Object)
	051 Move rdi, [rbx+16]
	052 Compare [rcx+228], 0
	053 JumpIfNotEqual {55}
	054 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	055 Move r8, 0
	056 Move rdx, 0
	057 Move rcx, rdi
	058 Call Object.op_Inequality, rcx, rdx, r8
	059 Compare rax, 0
	060 JumpIfEqual {102}
	061 Move rcx, [rbx+16]
	062 Compare rcx, 0
	063 JumpIfEqual {120}
	064 Move rdx, 0
	065 Call GameplayActivity.get_GameMode, rcx, rdx
	066 Goto {102}
	067 Compare rdi, 3
	068 JumpIfEqual {102}
	069 Compare rdi, 11
	070 JumpIfNotEqual {102}
	071 Move rcx, typeof(UnityEngine.Object)
	072 Move rdi, [rbx+16]
	073 Compare [rcx+228], 0
	074 JumpIfNotEqual {76}
	075 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	076 Move r8, 0
	077 Move rdx, 0
	078 Move rcx, rdi
	079 Call Object.op_Inequality, rcx, rdx, r8
	080 Compare rax, 0
	081 JumpIfEqual {102}
	082 Move rcx, [rbx+16]
	083 Compare rcx, 0
	084 JumpIfEqual {120}
	085 Move rdx, 0
	086 Call GameplayActivity.IsVersusMode, rcx, rdx
	087 Compare rax, 0
	088 JumpIfEqual {102}
	089 Move rcx, [rbx+24]
	090 Compare rcx, 0
	091 JumpIfEqual {120}
	092 Move r8, [rbx+52]
	093 Move r9, 0
	094 Move rdx, [rbx+116]
	095 Call Board.GetVSGravestoneAt, rcx, rdx, r8
	096 Compare rax, 0
	097 JumpIfEqual {102}
	098 Move rax, [rax+56]
	099 Add rax, rax, 11
	100 Goto {112}
	101 Move rsi, 3
	102 Move xmm1, [rbx+52]
	103 LoadAddress rax, [rsi+160]
	104 LoadAddress rdx, [rax+rax*4]
	105 Move r9, 0
	106 Move xmm2, rdx
	107 Move rcx, r14
	108 Move xmm2, xmm2
	109 Move xmm1, xmm1
	110 Subtract xmm2, xmm2, [rbx+32]
	111 Call Board.MakeRenderOrder, rcx, xmm1, xmm2, r9
	112 Move rbx, stack:0x30
	113 Move rbp, stack:0x38
	114 Move rsi, stack:0x40
	115 Move rdi, stack:0x48
	116 ShiftStack 32
	117 Move r14, stack:0x0
	118 ShiftStack 8
	119 Return rax
	120 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
