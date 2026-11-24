# System.Void UpdateIceShroom()

- 类：`Plant`
- 汇编行数：19

## 反汇编

```asm

Disassembly:
	cmp byte ptr [rcx+136h],0
	jne short 00000001806B9956h
	cmp dword ptr [rcx+88h],2
	je short 00000001806B9956h
	mov dword ptr [rcx+88h],2
	mov dword ptr [rcx+9Ch],64h
	ret

ISIL:
	001 Compare [rcx+310], 0
	002 JumpIfNotEqual {7}
	003 Compare [rcx+136], 2
	004 JumpIfEqual {7}
	005 Move [rcx+136], 2
	006 Move [rcx+156], 100
	007 Return
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
