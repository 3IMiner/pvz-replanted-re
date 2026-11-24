# UnityEngine.Sprite GetImage(Reloaded.Gameplay.SeedType theSeedtype)

- 类：`Plant`
- 汇编行数：25

## 反汇编

```asm

Disassembly:
	sub rsp,28h
	mov rcx,[rcx+10h]
	test rcx,rcx
	je short 00000001806B145Ch
	xor r8d,r8d
	call 00000001807DD8A0h
	xor eax,eax
	add rsp,28h
	ret
	call 00000001804FEE20h

ISIL:
	001 ShiftStack -40
	002 Move rcx, [rcx+16]
	003 Compare rcx, 0
	004 JumpIfEqual {10}
	005 Move r8, 0
	006 Call GameplayActivity.GetPlantDefinition, rcx, rdx
	007 Move rax, 0
	008 ShiftStack 40
	009 Return rax
	010 Call 0x1804FEE20, rcx, rdx, r8, r9
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
