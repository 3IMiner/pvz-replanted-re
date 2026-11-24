# System.Void UpdateInternal()

- 类：`Plant`
- 汇编行数：62

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,20h
	xor edx,edx
	mov rbx,rcx
	call 00000001806B6170h
	xor edx,edx
	mov rcx,rbx
	call 00000001806AB9B0h
	cmp dword ptr [rbx+8Ch],0
	jge short 00000001806B9B6Dh
	xor edx,edx
	mov rcx,rbx
	call 00000001806ACD40h
	xor edx,edx
	mov rcx,rbx
	call 00000001806BB7F0h
	mov rcx,[rbx+140h]
	test rcx,rcx
	je short 00000001806B9B99h
	xor edx,edx
	call 00000001807C8A50h
	xor edx,edx
	mov rcx,rbx
	add rsp,20h
	pop rbx
	jmp near ptr 00000001806AEDE0h
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -32
	004 Move rdx, 0
	005 Move rbx, rcx
	006 Call Plant.UpdateAbilities, rcx, rdx
	007 Move rdx, 0
	008 Move rcx, rbx
	009 Call Plant.Animate, rcx, rdx
	010 Compare [rbx+140], 0
	011 JumpIfGreaterOrEqual {15}
	012 Move rdx, 0
	013 Move rcx, rbx
	014 Call Plant.Die, rcx, rdx
	015 Move rdx, 0
	016 Move rcx, rbx
	017 Call Plant.UpdateReanim, rcx, rdx
	018 Move rcx, [rbx+320]
	019 Compare rcx, 0
	020 JumpIfEqual {30}
	021 Move rdx, 0
	022 Call ReloadedCharacterController.UpdateAnim, rcx, rdx
	023 Move rdx, 0
	024 Move rcx, rbx
	025 ShiftStack 32
	026 Move rbx, stack:0x0
	027 ShiftStack 8
	028 Call Plant.Draw, rcx, rdx
	029 Return 
	030 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
