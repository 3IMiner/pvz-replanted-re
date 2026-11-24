# System.Boolean IsSpiky()

- 类：`Plant`
- 汇编行数：19

## 反汇编

```asm

Disassembly:
	cmp dword ptr [rcx+70h],15h
	je short 00000001806B243Eh
	cmp dword ptr [rcx+70h],2Eh
	sete al
	ret
	mov al,1
	ret

ISIL:
	001 Compare [rcx+112], 21
	002 JumpIfEqual {6}
	003 Compare [rcx+112], 46
	004 NotImplemented "sete al"
	005 Return rax
	006 Move rax, 1
	007 Return rax
```

## C# 还原

```csharp
// TODO: 按上面汇编还原
public static ???
{
    throw new NotImplementedException();
}
```
