# System.Int32 GetCost(Reloaded.TreeStateActivities.GameplayActivity gLawnApp, Reloaded.Gameplay.SeedType theSeedType, Reloaded.Gameplay.SeedType theImitaterType)

- 类：`Plant`
- 汇编行数：268

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rsi
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB642h],0
	mov esi,r8d
	mov ebx,edx
	mov rdi,rcx
	jne short 00000001806B1153h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB642h],1
	test rdi,rdi
	je near ptr 00000001806B12E4h
	xor edx,edx
	mov rcx,rdi
	call 00000001807E3010h
	cmp eax,14h
	je short 00000001806B117Ah
	xor edx,edx
	mov rcx,rdi
	call 00000001807E3010h
	cmp eax,18h
	jne short 00000001806B11A7h
	cmp ebx,7
	je near ptr 00000001806B12CFh
	cmp ebx,0Ah
	je near ptr 00000001806B12BAh
	cmp ebx,17h
	je near ptr 00000001806B12A5h
	cmp ebx,36h
	je near ptr 00000001806B1290h
	cmp ebx,37h
	je near ptr 00000001806B127Bh
	cmp ebx,30h
	jne near ptr 00000001806B1232h
	cmp esi,0FFFFFFFFh
	je short 00000001806B1232h
	xor r8d,r8d
	mov edx,esi
	mov rcx,rdi
	call 00000001807DD8A0h
	mov rbx,rax
	xor edx,edx
	mov rcx,rdi
	call 00000001807DF9F0h
	test rbx,rbx
	je near ptr 00000001806B12E4h
	test al,al
	jne short 00000001806B121Fh
	movd xmm0,dword ptr [rbx+48h]
	mov eax,66666667h
	cvtdq2ps xmm0,xmm0
	mulss xmm0,dword ptr [rdi+0D8h]
	cvttss2si r8d,xmm0
	imul r8d
	sar edx,1
	mov eax,edx
	shr eax,1Fh
	add edx,eax
	lea ecx,[rdx+rdx*4]
	cmp r8d,ecx
	lea eax,[rcx+5]
	cmove eax,r8d
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,[rbx+4Ch]
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	xor r8d,r8d
	mov edx,ebx
	mov rcx,rdi
	call 00000001807DD8A0h
	mov rcx,[184C2D478h]
	mov rbx,rax
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B1257h
	call 00000001804FEEB0h
	xor edx,edx
	mov rcx,rbx
	call 0000000183832870h
	test al,al
	jne near ptr 00000001806B11C5h
	xor eax,eax
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,0C8h
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,64h
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,0FAh
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov eax,1F4h
	mov rbx,[rsp+30h]
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	mov rbx,[rsp+30h]
	mov eax,3E8h
	mov rsi,[rsp+38h]
	add rsp,20h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -32
	006 Compare [0x184EEB642], 0
	007 Move rsi, r8
	008 Move rbx, rdx
	009 Move rdi, rcx
	010 JumpIfNotEqual {14}
	011 LoadAddress rcx, [0x184C2D478]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 Move [0x184EEB642], 1
	014 Compare rdi, 0
	015 JumpIfEqual {137}
	016 Move rdx, 0
	017 Move rcx, rdi
	018 Call GameplayActivity.get_GameMode, rcx, rdx
	019 Compare rax, 20
	020 JumpIfEqual {26}
	021 Move rdx, 0
	022 Move rcx, rdi
	023 Call GameplayActivity.get_GameMode, rcx, rdx
	024 Compare rax, 24
	025 JumpIfNotEqual {36}
	026 Compare rbx, 7
	027 JumpIfEqual {130}
	028 Compare rbx, 10
	029 JumpIfEqual {123}
	030 Compare rbx, 23
	031 JumpIfEqual {116}
	032 Compare rbx, 54
	033 JumpIfEqual {109}
	034 Compare rbx, 55
	035 JumpIfEqual {102}
	036 Compare rbx, 48
	037 JumpIfNotEqual {81}
	038 Compare rsi, 18446744073709551615
	039 JumpIfEqual {81}
	040 Move r8, 0
	041 Move rdx, rsi
	042 Move rcx, rdi
	043 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	044 Move rbx, rax
	045 Move rdx, 0
	046 Move rcx, rdi
	047 Call GameplayActivity.IsVersusMode, rcx, rdx
	048 Compare rbx, 0
	049 JumpIfEqual {137}
	050 Compare rax, 0
	051 JumpIfNotEqual {74}
	052 Move xmm0, [rbx+72]
	053 Move rax, 0x66666667
	054 Move xmm0, xmm0
	055 Multiply xmm0, xmm0, [rdi+216]
	056 NotImplemented "cvttss2si r8d,xmm0"
	057 NotImplemented "imul r8d"
	058 ShiftRight rdx, 1
	059 Move rax, rdx
	060 ShiftRight rax, 31
	061 Add rdx, rdx, rax
	062 LoadAddress rcx, [rdx+rdx*4]
	063 Compare r8, rcx
	064 LoadAddress rax, [rcx+5]
	065 JumpIfNotEqual {67}
	066 Move rax, r8
	067 Nop 
	068 Move rbx, stack:0x30
	069 Move rsi, stack:0x38
	070 ShiftStack 32
	071 Move rdi, stack:0x0
	072 ShiftStack 8
	073 Return rax
	074 Move rax, [rbx+76]
	075 Move rbx, stack:0x30
	076 Move rsi, stack:0x38
	077 ShiftStack 32
	078 Move rdi, stack:0x0
	079 ShiftStack 8
	080 Return rax
	081 Move r8, 0
	082 Move rdx, rbx
	083 Move rcx, rdi
	084 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	085 Move rcx, typeof(UnityEngine.Object)
	086 Move rbx, rax
	087 Compare [rcx+228], 0
	088 JumpIfNotEqual {90}
	089 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	090 Move rdx, 0
	091 Move rcx, rbx
	092 Call Object.op_Implicit, rcx, rdx
	093 Compare rax, 0
	094 JumpIfNotEqual {45}
	095 Move rax, 0
	096 Move rbx, stack:0x30
	097 Move rsi, stack:0x38
	098 ShiftStack 32
	099 Move rdi, stack:0x0
	100 ShiftStack 8
	101 Return rax
	102 Move rax, 200
	103 Move rbx, stack:0x30
	104 Move rsi, stack:0x38
	105 ShiftStack 32
	106 Move rdi, stack:0x0
	107 ShiftStack 8
	108 Return rax
	109 Move rax, 100
	110 Move rbx, stack:0x30
	111 Move rsi, stack:0x38
	112 ShiftStack 32
	113 Move rdi, stack:0x0
	114 ShiftStack 8
	115 Return rax
	116 Move rax, 250
	117 Move rbx, stack:0x30
	118 Move rsi, stack:0x38
	119 ShiftStack 32
	120 Move rdi, stack:0x0
	121 ShiftStack 8
	122 Return rax
	123 Move rax, 500
	124 Move rbx, stack:0x30
	125 Move rsi, stack:0x38
	126 ShiftStack 32
	127 Move rdi, stack:0x0
	128 ShiftStack 8
	129 Return rax
	130 Move rbx, stack:0x30
	131 Move rax, 1000
	132 Move rsi, stack:0x38
	133 ShiftStack 32
	134 Move rdi, stack:0x0
	135 ShiftStack 8
	136 Return rax
	137 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
