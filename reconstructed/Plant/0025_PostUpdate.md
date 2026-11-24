# System.Void PostUpdate()

- 类：`Plant`
- 汇编行数：71

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB636h],0
	mov rbx,rcx
	jne short 00000001806B4DC9h
	lea rcx,[184C2D478h]
	call 00000001804FEB70h
	mov byte ptr [184EEB636h],1
	mov rcx,[184C2D478h]
	mov rdi,[rbx+140h]
	cmp dword ptr [rcx+0E4h],0
	jne short 00000001806B4DE5h
	call 00000001804FEEB0h
	xor r8d,r8d
	xor edx,edx
	mov rcx,rdi
	call 0000000183832900h
	test al,al
	je short 00000001806B4E15h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B4E20h
	mov rdx,[rcx]
	mov rax,[rdx+2B8h]
	mov rdx,[rdx+2C0h]
	call rax
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	ret
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Compare [0x184EEB636], 0
	006 Move rbx, rcx
	007 JumpIfNotEqual {11}
	008 LoadAddress rcx, [0x184C2D478]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 Move [0x184EEB636], 1
	011 Move rcx, typeof(UnityEngine.Object)
	012 Move rdi, [rbx+320]
	013 Compare [rcx+228], 0
	014 JumpIfNotEqual {16}
	015 Call "il2cpp_runtime_class_init_export", rcx, rdx, r8, r9
	016 Move r8, 0
	017 Move rdx, 0
	018 Move rcx, rdi
	019 Call Object.op_Inequality, rcx, rdx, r8
	020 Compare rax, 0
	021 JumpIfEqual {29}
	022 Move rcx, [rbx+320]
	023 Compare rcx, 0
	024 JumpIfEqual {34}
	025 Move rdx, [rcx]
	026 Move rax, [rdx+696]
	027 Move rdx, [rdx+704]
	028 Call rax
	029 Move rbx, stack:0x30
	030 ShiftStack 32
	031 Move rdi, stack:0x0
	032 ShiftStack 8
	033 Return 
	034 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
