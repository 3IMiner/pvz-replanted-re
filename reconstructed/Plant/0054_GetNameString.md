# System.String GetNameString(Reloaded.TreeStateActivities.GameplayActivity app, Reloaded.Gameplay.SeedType theSeedtype, Reloaded.Gameplay.SeedType theImitaterType)

- 类：`Plant`
- 汇编行数：169

## 反汇编

```asm

Disassembly:
	mov [rsp+10h],rbx
	mov [rsp+18h],rsi
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB643h],0
	mov edi,r8d
	mov esi,edx
	mov rbx,rcx
	jne short 00000001806B14D3h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C51560h]
	call 00000001804FEB70h
	lea rcx,[184C47740h]
	call 00000001804FEB70h
	lea rcx,[184C3D780h]
	call 00000001804FEB70h
	lea rcx,[184C54578h]
	call 00000001804FEB70h
	mov byte ptr [184EEB643h],1
	test rbx,rbx
	je near ptr 00000001806B15C6h
	xor r8d,r8d
	mov edx,esi
	mov rcx,rbx
	call 00000001807DD8A0h
	test rax,rax
	je near ptr 00000001806B15C6h
	mov r8,[184C54578h]
	xor r9d,r9d
	mov rdx,[rax+68h]
	mov rcx,[184C3D780h]
	mov [rsp+30h],rbp
	call 0000000182A1D150h
	mov rcx,[184C2AFC0h]
	mov rbp,rax
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B1529h
	call 00000001804FEEB0h
	xor edx,edx
	mov rcx,rbp
	call 00000001806CD400h
	mov rbp,[rsp+30h]
	cmp esi,30h
	jne short 00000001806B15B6h
	cmp edi,0FFFFFFFFh
	je short 00000001806B15B6h
	xor r8d,r8d
	mov edx,edi
	mov rcx,rbx
	call 00000001807DD8A0h
	test rax,rax
	je short 00000001806B15C6h
	mov r8,[184C54578h]
	xor r9d,r9d
	mov rdx,[rax+68h]
	mov rcx,[184C3D780h]
	call 0000000182A1D150h
	mov rcx,[184C2AFC0h]
	mov rbx,rax
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B1586h
	call 00000001804FEEB0h
	xor edx,edx
	mov rcx,rbx
	call 00000001806CD400h
	mov rcx,[184C47740h]
	xor edx,edx
	mov rbx,rax
	call 00000001806CD400h
	mov rdx,[184C51560h]
	xor r9d,r9d
	mov r8,rbx
	mov rcx,rax
	call 00000001806CD1D0h
	mov rbx,[rsp+38h]
	mov rsi,[rsp+40h]
	add rsp,20h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x10, rbx
	002 Move stack:0x18, rsi
	003 ShiftStack -8
	004 Move stack:0x0, rdi
	005 ShiftStack -32
	006 Compare [0x184EEB643], 0
	007 Move rdi, r8
	008 Move rsi, rdx
	009 Move rbx, rcx
	010 JumpIfNotEqual {22}
	011 LoadAddress rcx, [0x184C2AFC0]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C51560]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 LoadAddress rcx, [0x184C47740]
	016 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	017 LoadAddress rcx, [0x184C3D780]
	018 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	019 LoadAddress rcx, [0x184C54578]
	020 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	021 Move [0x184EEB643], 1
	022 Compare rbx, 0
	023 JumpIfEqual {83}
	024 Move r8, 0
	025 Move rdx, rsi
	026 Move rcx, rbx
	027 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	028 Compare rax, 0
	029 JumpIfEqual {83}
	030 Move r8, "]"
	031 Move r9, 0
	032 Move rdx, [rax+104]
	033 Move rcx, "["
	034 Move stack:0x30, rbp
	035 Call String.Concat, rcx, rdx, r8, r9
	036 Move rcx, typeof(Reloaded.Gameplay.Common)
	037 Move rbp, rax
	038 Compare [rcx+228], 0
	039 JumpIfNotEqual {41}
	040 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	041 Move rdx, 0
	042 Move rcx, rbp
	043 Call Common.TodStringTranslate, rcx, rdx
	044 Move rbp, stack:0x30
	045 Compare rsi, 48
	046 JumpIfNotEqual {77}
	047 Compare rdi, 18446744073709551615
	048 JumpIfEqual {77}
	049 Move r8, 0
	050 Move rdx, rdi
	051 Move rcx, rbx
	052 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	053 Compare rax, 0
	054 JumpIfEqual {83}
	055 Move r8, "]"
	056 Move r9, 0
	057 Move rdx, [rax+104]
	058 Move rcx, "["
	059 Call String.Concat, rcx, rdx, r8, r9
	060 Move rcx, typeof(Reloaded.Gameplay.Common)
	061 Move rbx, rax
	062 Compare [rcx+228], 0
	063 JumpIfNotEqual {65}
	064 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	065 Move rdx, 0
	066 Move rcx, rbx
	067 Call Common.TodStringTranslate, rcx, rdx
	068 Move rcx, "[IMITATED_PLANT]"
	069 Move rdx, 0
	070 Move rbx, rax
	071 Call Common.TodStringTranslate, rcx, rdx
	072 Move rdx, "{PLANT}"
	073 Move r9, 0
	074 Move r8, rbx
	075 Move rcx, rax
	076 Call Common.TodReplaceString, rcx, rdx, r8, r9
	077 Move rbx, stack:0x38
	078 Move rsi, stack:0x40
	079 ShiftStack 32
	080 Move rdi, stack:0x0
	081 ShiftStack 8
	082 Return rax
	083 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
