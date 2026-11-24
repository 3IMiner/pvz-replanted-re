# System.Void ImitaterMorph()

- 类：`Plant`
- 汇编行数：65

## 反汇编

```asm

Disassembly:
	push rbx
	sub rsp,40h
	xor edx,edx
	mov rbx,rcx
	call 00000001806ACD40h
	mov rcx,[rbx+18h]
	test rcx,rcx
	je short 00000001806B203Fh
	mov r9d,[rbx+12Ch]
	mov r8d,[rbx+34h]
	mov edx,[rbx+74h]
	mov qword ptr [rsp+38h],0
	mov byte ptr [rsp+30h],0
	mov byte ptr [rsp+28h],0
	mov dword ptr [rsp+20h],30h
	call 00000001806553E0h
	mov rbx,rax
	test rax,rax
	je short 00000001806B203Fh
	mov rcx,[rax+140h]
	test rcx,rcx
	je short 00000001806B203Fh
	xor edx,edx
	call 00000001807B6EF0h
	mov byte ptr [rbx+139h],1
	add rsp,40h
	pop rbx
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -8
	002 Move stack:0x0, rbx
	003 ShiftStack -64
	004 Move rdx, 0
	005 Move rbx, rcx
	006 Call Plant.Die, rcx, rdx
	007 Move rcx, [rbx+24]
	008 Compare rcx, 0
	009 JumpIfEqual {31}
	010 Move r9, [rbx+300]
	011 Move r8, [rbx+52]
	012 Move rdx, [rbx+116]
	013 Move stack:0x38, 0
	014 Move stack:0x30, 0
	015 Move stack:0x28, 0
	016 Move stack:0x20, 48
	017 Call Board.AddPlant, rcx, rdx, r8, r9, stack:0x0, stack:0x8, stack:0x10
	018 Move rbx, rax
	019 Compare rax, 0
	020 JumpIfEqual {31}
	021 Move rcx, [rax+320]
	022 Compare rcx, 0
	023 JumpIfEqual {31}
	024 Move rdx, 0
	025 Call PlantController.EnableGrayscale, rcx, rdx
	026 Move [rbx+313], 1
	027 ShiftStack 64
	028 Move rbx, stack:0x0
	029 ShiftStack 8
	030 Return 
	031 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
