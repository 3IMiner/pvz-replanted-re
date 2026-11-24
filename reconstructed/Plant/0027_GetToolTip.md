# System.String GetToolTip(Reloaded.Gameplay.SeedType theSeedType)

- 类：`Plant`
- 汇编行数：86

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB644h],0
	mov edi,edx
	mov rbx,rcx
	jne short 00000001806B1BF3h
	lea rcx,[184C2AFC0h]
	call 00000001804FEB70h
	lea rcx,[184C7D2B0h]
	call 00000001804FEB70h
	lea rcx,[184C3D780h]
	call 00000001804FEB70h
	mov byte ptr [184EEB644h],1
	mov rcx,[rbx+10h]
	test rcx,rcx
	je short 00000001806B1C51h
	xor r8d,r8d
	mov edx,edi
	call 00000001807DD8A0h
	test rax,rax
	je short 00000001806B1C51h
	mov r8,[184C7D2B0h]
	xor r9d,r9d
	mov rdx,[rax+68h]
	mov rcx,[184C3D780h]
	call 0000000182A1D150h
	mov rcx,[184C2AFC0h]
	mov rbx,rax
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B1C3Dh
	call 00000001804FEEB0h
	xor edx,edx
	mov rcx,rbx
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001806CD400h
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Compare [0x184EEB644], 0
	006 Move rdi, rdx
	007 Move rbx, rcx
	008 JumpIfNotEqual {16}
	009 LoadAddress rcx, [0x184C2AFC0]
	010 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	011 LoadAddress rcx, [0x184C7D2B0]
	012 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	013 LoadAddress rcx, [0x184C3D780]
	014 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	015 Move [0x184EEB644], 1
	016 Move rcx, [rbx+16]
	017 Compare rcx, 0
	018 JumpIfEqual {42}
	019 Move r8, 0
	020 Move rdx, rdi
	021 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	022 Compare rax, 0
	023 JumpIfEqual {42}
	024 Move r8, "_TOOLTIP]"
	025 Move r9, 0
	026 Move rdx, [rax+104]
	027 Move rcx, "["
	028 Call String.Concat, rcx, rdx, r8, r9
	029 Move rcx, typeof(Reloaded.Gameplay.Common)
	030 Move rbx, rax
	031 Compare [rcx+228], 0
	032 JumpIfNotEqual {34}
	033 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	034 Move rdx, 0
	035 Move rcx, rbx
	036 Move rbx, stack:0x30
	037 ShiftStack 32
	038 Move rdi, stack:0x0
	039 ShiftStack 8
	040 Call Common.TodStringTranslate, rcx, rdx
	041 Return rax
	042 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
