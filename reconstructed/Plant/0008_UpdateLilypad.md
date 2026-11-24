# System.Void UpdateLilypad()

- 类：`Plant`
- 汇编行数：17

## 反汇编

```asm

Disassembly:
	cmp dword ptr [rcx+88h],30h
	jne short 00000001806B9BBCh
	cmp dword ptr [rcx+0A0h],0
	jne short 00000001806B9BBCh
	mov dword ptr [rcx+88h],0
	ret

ISIL:
	001 Compare [rcx+136], 48
	002 JumpIfNotEqual {6}
	003 Compare [rcx+160], 0
	004 JumpIfNotEqual {6}
	005 Move [rcx+136], 0
	006 Return
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
