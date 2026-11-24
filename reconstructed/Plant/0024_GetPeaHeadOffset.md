# Unity.Mathematics.float2 GetPeaHeadOffset()

- 类：`Plant`
- 汇编行数：70

## 反汇编

```asm

Disassembly:
	mov [rsp+8],rbx
	push rdi
	sub rsp,20h
	cmp byte ptr [184EEB650h],0
	mov rdi,rcx
	jne short 00000001806B1605h
	lea rcx,[184C95FA8h]
	call 00000001804FEB70h
	lea rcx,[184C98E08h]
	call 00000001804FEB70h
	mov byte ptr [184EEB650h],1
	mov rcx,[rdi+140h]
	mov rbx,[184C95FA8h]
	test rcx,rcx
	je short 00000001806B1652h
	mov rdx,[184C98E08h]
	xor r8d,r8d
	call 00000001807C7CC0h
	test al,al
	cmovne rbx,[184C98E08h]
	mov rcx,[rdi+140h]
	test rcx,rcx
	je short 00000001806B1652h
	xor r8d,r8d
	mov rdx,rbx
	mov rbx,[rsp+30h]
	add rsp,20h
	pop rdi
	jmp near ptr 00000001807C7BA0h
	call 00000001804FEE20h

ISIL:
	001 Move stack:0x8, rbx
	002 ShiftStack -8
	003 Move stack:0x0, rdi
	004 ShiftStack -32
	005 Compare [0x184EEB650], 0
	006 Move rdi, rcx
	007 JumpIfNotEqual {13}
	008 LoadAddress rcx, [0x184C95FA8]
	009 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	010 LoadAddress rcx, [0x184C98E08]
	011 Call "il2cpp_codegen_initialize_runtime_metadata", rcx, rdx, r8, r9
	012 Move [0x184EEB650], 1
	013 Move rcx, [rdi+320]
	014 Move rbx, "anim_idle"
	015 Compare rcx, 0
	016 JumpIfEqual {35}
	017 Move rdx, "anim_stem"
	018 Move r8, 0
	019 Call ReloadedCharacterController.HasBone, rcx, rdx
	020 Compare rax, 0
	021 JumpIfEqual {23}
	022 Move rbx, "anim_stem"
	023 Nop 
	024 Move rcx, [rdi+320]
	025 Compare rcx, 0
	026 JumpIfEqual {35}
	027 Move r8, 0
	028 Move rdx, rbx
	029 Move rbx, stack:0x30
	030 ShiftStack 32
	031 Move rdi, stack:0x0
	032 ShiftStack 8
	033 Call ReloadedCharacterController.GetTrackPosition, rcx, rdx
	034 Return rax
	035 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
